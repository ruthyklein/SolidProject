using Solid.Core.Entities;

namespace Solid.Core.Services
{
    public interface IPatientService
    {
        Task<IEnumerable<Patient>> GetPatientAsync();

        Task<Patient> GetByIdAsync(int id);

        Task<Patient> AddPatientAsync(Patient patient);

        Task<Patient> UpdatePatientAsync(int id, Patient patient);

        Task DeletePatientAsync(int id);
    }
}
