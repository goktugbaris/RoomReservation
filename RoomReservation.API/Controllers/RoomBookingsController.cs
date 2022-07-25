using AutoMapper;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using RoomReservation.Api.Dto;
using RoomReservation.Business.Abstract;
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
    }
}
