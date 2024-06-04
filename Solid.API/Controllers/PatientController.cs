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
    public class PatientController : ControllerBase
    {
        private readonly IPatientService _patientService;
        private readonly IMapper _mapper;

        public PatientController(IPatientService patientService, IMapper mapper)
        {
            _patientService = patientService;
            _mapper = mapper;
        }

        [HttpGet]
        public async Task<IActionResult> Get()
        {
            var patients = await _patientService.GetPatientAsync();
            var patientDtos = _mapper.Map<IEnumerable<PatientDto>>(patients);
            return Ok(patientDtos);
        }

        [HttpGet("{id}")]
        public async Task<IActionResult> Get(int id)
        {
            var patient = await _patientService.GetByIdAsync(id);
            if (patient == null)
            {
                return NotFound();
            }
            var patientDto = _mapper.Map<PatientDto>(patient);
            return Ok(patientDto);
        }

        [HttpPost]
        public async Task<ActionResult> Post([FromBody] Patient patient)
        {
            var addedPatient = await _patientService.AddPatientAsync(patient);
            var patientDto = _mapper.Map<PatientDto>(addedPatient);
            return Ok(patientDto);
        }

        [HttpPut("{id}")]
        public async Task<ActionResult> Put(int id, [FromBody] Patient patient)
        {
            var updatedPatient = await _patientService.UpdatePatientAsync(id, patient);
            var patientDto = _mapper.Map<PatientDto>(updatedPatient);
            return Ok(patientDto);
        }

        [HttpDelete("{id}")]
        public async Task<ActionResult> Delete(int id)
        {
            await _patientService.DeletePatientAsync(id);
            return NoContent();
        }
    }
}
