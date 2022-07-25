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
    public class EmployeesController : ControllerBase
    {
        private readonly IMapper _mapper;
        private IEmployeeService _employeeService;
        public EmployeesController(IEmployeeService employeeService, IMapper mapper)
        {
            _employeeService = employeeService;
            _mapper = mapper;
        }
        [HttpGet]
        public async Task<ActionResult> Get()
        {
            var employees = await _employeeService.GetAll();
            var employeesToReturn = _mapper.Map<List<EmployeeDto>>(employees);
            return Ok(employeesToReturn);
        }
        [HttpGet("{id}")]
        public async Task<ActionResult> Get(int id)
        {
            var employee = await _employeeService.GetById(id);
            var employeeToReturn = _mapper.Map<Entities.Employee, EmployeeDto>(employee);
            return Ok(employeeToReturn);
        }
        [HttpPost]
        [Route("add")]
        public async Task<ActionResult> Add([FromBody] Employee employee)
        {
            if (employee == null)
            {
                return BadRequest();
            }
            await _employeeService.Create(employee);
            return Ok(employee);
        }
        [HttpPut]
        [Route("update")]
        public async Task<IActionResult> Update([FromBody] Employee employee)
        {
            if (employee == null)
            {
                return NotFound();
            }
            await _employeeService.Update(employee);
            return NoContent();
        }
        [HttpDelete("{id}")]
        public async Task<IActionResult> Delete(int id)
        {
            var entity = await _employeeService.GetById(id);

            if (entity == null)
            {
                return NotFound();
            }

            await _employeeService.Delete(entity);
            return NoContent();
        }
    }
}
