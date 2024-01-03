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

        public PatientController(IPatientService PatientService)
        {
            _patientService = PatientService;
        }

        // GET: api/<PatientController>
        [HttpGet]
        public IActionResult Get()
        {
            return Ok(_patientService.GetPatient());
        }

        // GET api/<PatientController>/5
        [HttpGet("{id}")]
        public IActionResult Get(int id)
        {
            var pat = _patientService.GetById(id);
            if (pat is null)
            {
                return NotFound();
            }
            return Ok(pat);
 
        }

        // POST api/<PatientController>
        [HttpPost]
        public ActionResult Post([FromBody] Patient patient)
        {
            return Ok(_patientService.AddPatient(patient));
        }


        // PUT api/<PatientController>/5
        [HttpPut("{id}")]
        public ActionResult Put(int id, [FromBody] Patient patient)
        {
            return Ok(_patientService.UpdatePatient(id, patient));

        }

        // DELETE api/<AppointmentController>/5
        [HttpDelete("{id}")]
        public ActionResult Delete(int id)
        {
            _patientService.DeletePatient(id);
            return NoContent();
        }
    }
}
