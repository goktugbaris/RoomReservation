using AutoMapper;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using RoomReservation.Api.Dto;
using RoomReservation.Business.Abstract;
using RoomReservation.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace RoomReservation.Api.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class RoomBookingsController : ControllerBase
    {
        private readonly IMapper _mapper;
        private IRoomBookingService _roomBookingService;
        public RoomBookingsController(IRoomBookingService roomBookingService, IMapper mapper)
        {
            _roomBookingService = roomBookingService;
            _mapper = mapper;
        }
        [HttpGet]
        public async Task<ActionResult> Get()
        {
            var roomBookings = await _roomBookingService.GetAll();
            var roomBookingToReturn = _mapper.Map<List<RoomBookingDto>>(roomBookings);
            return Ok(roomBookingToReturn);
        }
        [HttpGet("{id}")]
        public async Task<ActionResult> Get(int id)
        {
            var roomBooking = await _roomBookingService.GetById(id);
            var rooBookingToReturn = _mapper.Map<Entities.RoomBooking, RoomBookingDto>(roomBooking);
            return Ok(rooBookingToReturn);
        }
        [HttpPost]
        [Route("add")]
        public async Task<ActionResult> Add([FromBody] RoomBooking roomBooking)
        {
            if (roomBooking == null)
            {
                return BadRequest();
            }
            await _roomBookingService.Create(roomBooking);
            return Ok(roomBooking);
        }
        [HttpPut]
        [Route("update")]
        public async Task<IActionResult> Update([FromBody] RoomBooking roomBooking)
        {
            if (roomBooking == null)
            {
                return NotFound();
            }
            await _roomBookingService.Update(roomBooking);
            return NoContent();
        }
        [HttpDelete("{id}")]
        public async Task<IActionResult> Delete(int id)
        {
            var entity = await _roomBookingService.GetById(id);

            if (entity == null)
            {
                return NotFound();
            }

            await _roomBookingService.Delete(entity);
            return NoContent();
        }
    }
}
