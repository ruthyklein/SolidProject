using AutoMapper;
using Microsoft.AspNetCore.Mvc;
using Solid.Core.Entities;
using Solid.Core.Services;
using Solid.Data;
using Solid.Service.Services;
using System.Net;
using System.Numerics;
using System.Xml.Linq;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace Solid.API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class PatientController : ControllerBase
    {
        private readonly IPatientService _patientService;
        private readonly IMapper _mapper;
        public PatientController(IPatientService PatientService, IMapper mapper)
        {
            _patientService = PatientService;
            _mapper = mapper;
        }

        // GET: api/<PatientController>
        [HttpGet]
        public async Task<IActionResult> Get()
        {
            return Ok(await _patientService.GetPatientAsync());
        }

        // GET api/<PatientController>/5
        [HttpGet("{id}")]
        public async Task<IActionResult> Get(int id)
        {
            var pat = _patientService.GetByIdAsync(id);
            if (pat is null)
            {
                return NotFound();
            }
            return Ok(await pat);
 
        }

        // POST api/<PatientController>
        [HttpPost]
        public async Task<ActionResult> Post([FromBody] Patient patient)
        {
            return Ok(await _patientService.AddPatientAsync(patient));
        }


        // PUT api/<PatientController>/5
        [HttpPut("{id}")]
        public async Task<ActionResult> Put(int id, [FromBody] Patient patient)
        {
            return Ok(await _patientService.UpdatePatientAsync(id, patient));
        }

        // DELETE api/<AppointmentController>/5
        [HttpDelete("{id}")]
        public async Task<ActionResult> Delete(int id)
        {
            await _patientService.DeletePatientAsync(id);
            return NoContent();
        }
    }
}
