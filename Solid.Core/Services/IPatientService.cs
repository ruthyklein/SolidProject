using Solid.Core.Entities;

namespace Solid.Core.Services
{
    public interface IPatientService
    {
        List<Patient> GetPatient();

        Patient GetById(int id);

        void AddPatient(Patient patient);

        void UpdatePatient(int id, Patient patient);

        void DeletePatient(int id);
    }
}
