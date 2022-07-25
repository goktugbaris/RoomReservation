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
    public class DepartmentsController : ControllerBase
    {
        private readonly IMapper _mapper;
        private IDepartmentService _departmentService;
        public DepartmentsController(IDepartmentService departmentService, IMapper mapper)
        {
            _departmentService = departmentService;
            _mapper = mapper;
        }
        [HttpGet]
        public async Task<ActionResult> Get()
        {
            var departments = await _departmentService.GetAll();
            var departmentsToReturn = _mapper.Map<List<DepartmentDto>>(departments);
            return Ok(departmentsToReturn);
        }
        [HttpGet("{id}")]
        public async Task<ActionResult> Get(int id)
        {
            var department = await _departmentService.GetById(id);
            var departmentToReturn = _mapper.Map<Entities.Department, DepartmentDto>(department);
            return Ok(departmentToReturn);
        }
    }
}

