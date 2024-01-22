using Solid.Core.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Solid.Core.Repositories
{
    public interface IDoctorRepository
    {
        Task<IEnumerable<Doctor>> GetDoctorAsync();

        Task<Doctor> GetByIdAsync(int id);

        Task<Doctor> AddDoctorAsync(Doctor doctor);

        Task<Doctor> UpdateDoctorAsync(int id, Doctor doctor);

        Task DeleteDoctorAsync(int id);
    }
}
