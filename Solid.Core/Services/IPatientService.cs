using Solid.Core.Entities;

namespace Solid.Core.Services
{
    public interface IPatientService
    {
        List<Patient> GetPatient();

        Patient GetById(int id);

        Patient AddPatient(Patient patient);

        Patient UpdatePatient(int id, Patient patient);

        void DeletePatient(int id);
    }
}
