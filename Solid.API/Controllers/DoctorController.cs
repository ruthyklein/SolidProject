using Microsoft.AspNetCore.Mvc;
using Solid.Core.Entities;
using Solid.Core.Services;
using Solid.Data;
using Solid.Service.Services;
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
            var doc = _doctorService.GetById(id);
            if (doc is null)
            {
                return NotFound();
            }
            return Ok(doc);
        }

        // POST api/<DoctorController>
        [HttpPost]
        public ActionResult Post([FromBody] Doctor doctor)
        {
           return Ok( _doctorService.AddDoctor(doctor));
        }


        // PUT api/<DoctorController>/5
        [HttpPut("{id}")]
        public ActionResult Put(int id, [FromBody] Doctor doctor)
        {
           return Ok(_doctorService.UpdateDoctor(id, doctor));
            
        }


        //// DELETE api/<DoctorController>/5
        [HttpDelete("{id}")]
        public ActionResult Delete(int id)
        {
            _doctorService.DeleteDoctor(id);
            return NoContent();
        }
    }
}
