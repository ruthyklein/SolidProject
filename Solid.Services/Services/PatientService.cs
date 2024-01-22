using Solid.Core.Entities;
using Solid.Core.Repositories;
using Solid.Core.Services;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Solid.Service.Services
{
    public class PatientService : IPatientService
    {
        private readonly IPatientRepository _patientRepository;

        public PatientService(IPatientRepository patientRepository)
        {
            _patientRepository = patientRepository;
        }

        public async Task<Patient> AddPatientAsync(Patient patient)
        {
            return await _patientRepository.AddPatientAsync(patient);
        }

        public async Task DeletePatientAsync(int id)
        {
            await _patientRepository.DeletePatientAsync(id);
        }

        public async Task<IEnumerable<Patient>> GetPatientAsync()
        {
            return await _patientRepository.GetPatientAsync();
        }

        public async Task<Patient> GetByIdAsync(int id)
        {
            return await _patientRepository.GetByIdAsync(id);
        }

        public async Task<Patient> UpdatePatientAsync(int id, Patient patient)
        {
           return await _patientRepository.UpdatePatientAsync(id, patient);
        }
    }
}
