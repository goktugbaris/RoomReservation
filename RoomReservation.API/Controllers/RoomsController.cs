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
    public class RoomsController : ControllerBase
    {
        private readonly IMapper _mapper;
        private IRoomService _roomService;
        public RoomsController(IRoomService roomService, IMapper mapper)
        {
            _roomService = roomService;
            _mapper = mapper;
        }
        [HttpGet]
        public async Task<ActionResult> Get()
        {
            var rooms = await _roomService.GetAll();
            var roomsToReturn = _mapper.Map<List<RoomDto>>(rooms);
            return Ok(roomsToReturn);
        }
        [HttpGet("{id}")]
        public async Task<ActionResult> Get(int id)
        {
            var room = await _roomService.GetById(id);
            var roomToReturn = _mapper.Map<Entities.Room, RoomDto>(room);
            return Ok(roomToReturn);
        }
        [HttpPost]
        [Route("add")]
        public async Task<ActionResult> Add([FromBody] Room room)
        {
            if (room == null)
            {
                return BadRequest();
            }
            await _roomService.Create(room);
            return Ok(room);
        }
        [HttpPut]
        [Route("update")]
        public async Task<IActionResult> Update([FromBody] Room room)
        {
            if (room == null)
            {
                return NotFound();
            }
            await _roomService.Update(room);
            return NoContent();
        }
        [HttpDelete("{id}")]
        public async Task<IActionResult> Delete(int id)
        {
            var entity = await _roomService.GetById(id);

            if (entity == null)
            {
                return NotFound();
            }

            await _roomService.Delete(entity);
            return NoContent();
        }
    }
}

