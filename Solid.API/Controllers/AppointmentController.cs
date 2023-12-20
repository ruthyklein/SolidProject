
using Microsoft.AspNetCore.Mvc;
using Solid.Core.Entities;
using Solid.Core.Services;

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
            //var appointment = _appointmentService.GetById(id);
            //if (appointment is null)
            //{
            //    return NotFound();
            //}
            //return Ok(appointment);
            return Ok(_appointmentService.GetById(id));
        }

        // POS
        // POST api/<AppointmentController>
        [HttpPost]
        public void Post([FromBody] Appointment appointment)
        {
            _appointmentService.AddAppointment(appointment);

            // appointments.Add(new Appointment { Id = appointment.Id, DateTime = appointment.DateTime, Doctor = appointment.Doctor, Patient = appointment.Patient});

        }

        // PUT api/<AppointmentController>/5
        [HttpPut("{id}")]
        public void Put(int id, [FromBody] Appointment appointment)
        {
            _appointmentService.UpdateAppointment(id, appointment);
        }

        // DELETE api/<AppointmentController>/5
        [HttpDelete("{id}")]
        public void Delete(int id)
        {
            _appointmentService.DeleteAppointment(id);
        }
    }
}
