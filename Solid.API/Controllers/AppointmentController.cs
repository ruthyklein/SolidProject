
using Microsoft.AspNetCore.Mvc;
using Solid.Core.Entities;
using Solid.Core.Services;
using Solid.Service.Services;

namespace Solid.API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class AppointmentController : ControllerBase
    {
        private readonly IAppointmentService _appointmentService;

        public AppointmentController(IAppointmentService appointmentService)
        {
            _appointmentService = appointmentService;
        }

        // GET: api/<AppointmentController>
        [HttpGet]
        public IActionResult Get()
        {
            return Ok(_appointmentService.GetAppointment());
        }

        
        // GET api/<AppointmentController>/5
        [HttpGet("{id}")]
        public IActionResult Get(int id)
        {
            var app = _appointmentService.GetById(id);
            if (app is null)
            {
                return NotFound();
            }
            return Ok(app);
        }
        
         // POST api/<AppointmentController>
        [HttpPost]
        public ActionResult Post([FromBody] Appointment appointment)
        {
            return Ok(_appointmentService.AddAppointment(appointment));

            // appointments.Add(new Appointment { Id = appointment.Id, DateTime = appointment.DateTime, Doctor = appointment.Doctor, Patient = appointment.Patient});

        }
        [HttpPut("{id}")]
        public ActionResult Put(int id, [FromBody] Appointment app)
        {
            return Ok(_appointmentService.UpdateAppointment(id, app));
        }

        // DELETE api/<AppointmentController>/5
        [HttpDelete("{id}")]
        public ActionResult Delete(int id)
        {
            _appointmentService.DeleteAppointment(id);
            return NoContent();
        }
    }
}
