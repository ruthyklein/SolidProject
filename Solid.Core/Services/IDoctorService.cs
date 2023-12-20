using Solid.Core.Entities;

namespace Solid.Core.Services
{
    public interface IDoctorService
    {
        List<Doctor> GetDoctor();

        Doctor GetById(int id);

        void AddDoctor(Doctor doctor);

        void UpdateDoctor(int id, Doctor doctor);

        void DeleteDoctor(int id);
    }
}
