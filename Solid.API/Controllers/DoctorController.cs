using Microsoft.AspNetCore.Mvc;
using System;
using System.Threading.Tasks;
using AutoMapper;
using Solid.Core.Entities;
using Solid.Core.DTOs;
using Solid.Core.Services;

namespace Solid.API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class DoctorController : ControllerBase
    {
        private readonly IDoctorService _doctorService;
        private readonly IMapper _mapper;

        public DoctorController(IDoctorService doctorService, IMapper mapper)
        {
            _doctorService = doctorService;
            _mapper = mapper;
        }

        [HttpGet]
        public async Task<IActionResult> Get()
        {
            var doctors = await _doctorService.GetDoctorAsync();
            var doctorDtos = _mapper.Map<IEnumerable<DoctorDto>>(doctors);
            return Ok(doctorDtos);
        }

        [HttpGet("{id}")]
        public async Task<IActionResult> Get(int id)
        {
            var doctor = await _doctorService.GetByIdAsync(id);
            if (doctor == null)
            {
                return NotFound();
            }
            var doctorDto = _mapper.Map<DoctorDto>(doctor);
            return Ok(doctorDto);
        }

        [HttpPost]
        public async Task<ActionResult> Post([FromBody] Doctor doctor)
        {
            var addedDoctor = await _doctorService.AddDoctorAsync(doctor);
            var doctorDto = _mapper.Map<DoctorDto>(addedDoctor);
            return Ok(doctorDto);
        }

        [HttpPut("{id}")]
        public async Task<ActionResult> Put(int id, [FromBody] Doctor doctor)
        {
            var updatedDoctor = await _doctorService.UpdateDoctorAsync(id, doctor);
            var doctorDto = _mapper.Map<DoctorDto>(updatedDoctor);
            return Ok(doctorDto);
        }

        [HttpDelete("{id}")]
        public async Task<ActionResult> Delete(int id)
        {
            await _doctorService.DeleteDoctorAsync(id);
            return NoContent();
        }
    }
}
