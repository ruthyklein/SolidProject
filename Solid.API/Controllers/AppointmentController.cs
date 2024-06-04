using Microsoft.AspNetCore.Mvc;
using AutoMapper;
using Solid.Core.Entities;
using Solid.Core.DTOs;
using Solid.Core.Services;

namespace Solid.API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class AppointmentController : ControllerBase
    {
        private readonly IAppointmentService _appointmentService;
        private readonly IMapper _mapper;

        public AppointmentController(IAppointmentService appointmentService, IMapper mapper)
        {
            _appointmentService = appointmentService;
            _mapper = mapper;
        }

        [HttpGet]
        public async Task<IActionResult> Get()
        {
            var appointments = await _appointmentService.GetAppointmentAsync();
            var appointmentDtos = _mapper.Map<IEnumerable<AppointmentDto>>(appointments);
            return Ok(appointmentDtos);
        }

        [HttpGet("{id}")]
        public async Task<IActionResult> Get(int id)
        {
            var appointment = await _appointmentService.GetByIdAsync(id);
            if (appointment == null)
            {
                return NotFound();
            }
            var appointmentDto = _mapper.Map<AppointmentDto>(appointment);
            return Ok(appointmentDto);
        }

        [HttpPost]
        public async Task<ActionResult> Post([FromBody] Appointment appointment)
        {
            var addedAppointment = await _appointmentService.AddAppointmentAsync(appointment);
            var appointmentDto = _mapper.Map<AppointmentDto>(addedAppointment);
            return Ok(appointmentDto);
        }

        [HttpPut("{id}")]
        public async Task<ActionResult> Put(int id, [FromBody] Appointment appointment)
        {
            var updatedAppointment = await _appointmentService.UpdateAppointmentAsync(id, appointment);
            var appointmentDto = _mapper.Map<AppointmentDto>(updatedAppointment);
            return Ok(appointmentDto);
        }

        [HttpDelete("{id}")]
        public async Task<ActionResult> Delete(int id)
        {
            await _appointmentService.DeleteAppointmentAsync(id);
            return NoContent();
        }
    }
}
