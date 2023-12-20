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
        List<Doctor> GetDoctor();

        Doctor GetById(int id);

        Doctor AddDoctor(Doctor doctor);

        Doctor UpdateDoctor(int id, Doctor doctor);

        void DeleteDoctor(int id);
    }
}
