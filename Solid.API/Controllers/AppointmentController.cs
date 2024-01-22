
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
        public async Task<IActionResult> Get()
        {
            return Ok(await _appointmentService.GetAppointmentAsync());
        }

        
        // GET api/<AppointmentController>/5
        [HttpGet("{id}")]
        public async Task<IActionResult> Get(int id)
        {
            var app = _appointmentService.GetByIdAsync(id);
            if (app is null)
            {
                return NotFound();
            }
            return Ok(await app);
        }
        
         // POST api/<AppointmentController>
        [HttpPost]
        public async Task<ActionResult> Post([FromBody] Appointment appointment)
        {
            return Ok(await _appointmentService.AddAppointmentAsync(appointment));

            // appointments.Add(new Appointment { Id = appointment.Id, DateTime = appointment.DateTime, Doctor = appointment.Doctor, Patient = appointment.Patient});

        }

        [HttpPut("{id}")]
        public async Task<ActionResult> Put(int id, [FromBody] Appointment app)
        {
            return Ok(await _appointmentService.UpdateAppointmentAsync(id, app));
        }

        // DELETE api/<AppointmentController>/5
        [HttpDelete("{id}")]
        public async Task<ActionResult> Delete(int id)
        {
            await _appointmentService.DeleteAppointmentAsync(id);
            return NoContent();
        }
    }
}
