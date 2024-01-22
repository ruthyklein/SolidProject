using Solid.Core.Entities;

namespace Solid.Core.Services
{
    public interface IDoctorService
    {
        Task<IEnumerable<Doctor>> GetDoctorAsync();

        Task<Doctor> GetByIdAsync(int id);

        Task<Doctor> AddDoctorAsync(Doctor doctor);

        Task<Doctor> UpdateDoctorAsync(int id, Doctor doctor);

        Task DeleteDoctorAsync(int id);
    }
}
