using Solid.Core.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Solid.Core.Repositories
{
    public interface IPatientRepository
    {
        Task<IEnumerable<Patient>> GetPatientAsync();

        Task<Patient> GetByIdAsync(int id);

        Task<Patient> AddPatientAsync(Patient patient);

        Task<Patient> UpdatePatientAsync(int id, Patient patient);

        Task DeletePatientAsync(int id);
    }
}
