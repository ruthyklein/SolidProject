using Microsoft.AspNetCore.Mvc;
using Solid.Core.Entities;
using Solid.Core.Services;
using Solid.Data;
using System.Net;
using System.Xml.Linq;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace Solid.API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class DoctorController : ControllerBase
    {
        private readonly IDoctorService _doctorService;

        public DoctorController(IDoctorService doctorService)
        {
            _doctorService = doctorService;
        }
        // GET: api/<DoctorController>
        [HttpGet]
        public IActionResult Get()
        {
            return Ok(_doctorService.GetDoctor());
        }

        // GET api/<DoctorController>/5
        [HttpGet("{id}")]
        public IActionResult Get(int id)
        {
            return Ok(_doctorService.GetById(id));
        }

        // POST api/<DoctorController>
        [HttpPost]
        public void Post([FromBody] Doctor doctor)
        {
            _doctorService.AddDoctor(doctor);
        }

        // PUT api/<DoctorController>/5
        [HttpPut("{id}")]
        public void Put(int id, [FromBody] Doctor doctor)
        {
            _doctorService.UpdateDoctor(id, doctor);
            
        }
        // PUT api/<DoctorController>/5/status

        [HttpPut("{id}/{status}")]
        public void Put(bool status, int id, [FromBody] Doctor doctor)
        {
            _doctorService.UpdateDoctor(id, doctor);
            //Doctor doc = _context.DoctorList.Find(p => p.Id == id);
            //if (doc != null)
            //    doc.Status = doctor.Status;
        }
        //// DELETE api/<DoctorController>/5
        //[HttpDelete("{id}")]
        //public void Delete(int id)
        //{
        //}
    }
}
