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
    public class OrganizationsController : ControllerBase
    {
        private readonly IMapper _mapper;
        private IOrganizationService _organizationService;
        public OrganizationsController(IOrganizationService organizationService, IMapper mapper)
        {
            _organizationService = organizationService;
            _mapper = mapper;
        }
        [HttpGet]
        public async Task<ActionResult> Get()
        {
            var organizations = await _organizationService.GetAll();
            var organizationsToReturn = _mapper.Map<List<OrganizationDto>>(organizations);
            return Ok(organizationsToReturn);
        }
        [HttpGet("{id}")]
        public async Task<ActionResult> Get(int id)
        {
            var organization = await _organizationService.GetById(id);
            var organizationToReturn = _mapper.Map<Organization,OrganizationDto>(organization);
            return Ok(organizationToReturn);
        }
        [HttpPost]
        [Route("add")]
        public async Task<ActionResult> Add([FromBody] Organization organization)
        {
            if (organization == null)
            {
                return BadRequest();
            }
            await _organizationService.Create(organization);
            return Ok(organization);
        }
        [HttpPut]
        [Route("update")]
        public async Task<IActionResult> Update([FromBody] Organization organization)
        {
            if (organization == null)
            {
                return NotFound();
            }
            await _organizationService.Update(organization);
            return Ok(organization);
        }
        [HttpDelete("{id}")]
        public async Task<IActionResult> Delete(int id)
        {
            var entity = await _organizationService.GetById(id);

            if (entity == null)
            {
                return NotFound();
            }

            await _organizationService.Delete(entity);
            return NoContent();
        }

    }
}
