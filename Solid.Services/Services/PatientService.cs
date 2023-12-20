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


        public void AddPatient(Patient patient)
        {
            _patientRepository.AddPatient(patient);
        }

        public void DeletePatient(int id)
        {
            _patientRepository.DeletePatient(id);
        }

        public List<Patient> GetPatient()
        {
            return _patientRepository.GetPatient();
        }

        public Patient GetById(int id)
        {
            return _patientRepository.GetById(id);
        }

        public void UpdatePatient(int id, Patient patient)
        {
            _patientRepository.UpdatePatient(id, patient);
        }
    }
}
