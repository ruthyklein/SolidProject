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
            return Ok(_patientService.GetById(id));
        }

        // POST api/<PatientController>
        [HttpPost]
        public void Post([FromBody] Patient patient)
        {
           _patientService.AddPatient(patient);
        }

        // PUT api/<PatientController>/5
        [HttpPut("{id}")]
        public void Put(int id, [FromBody] Patient patient)
        {
          _patientService.UpdatePatient(id, patient);

        }

        // PUT api/<PatientController>/5
        [HttpPut("{id}/{status}")]
        public void Put(bool status,int id, [FromBody] Patient patient)
        {
            _patientService.UpdatePatient(id, patient);
        }

        // DELETE api/<PatientController>/5
        //[HttpDelete("{id}")]
        //public void Delete(int id)
        //{
        //}
    }
}
