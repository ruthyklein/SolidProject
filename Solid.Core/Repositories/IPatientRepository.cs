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
        List<Patient> GetPatient();

        Patient GetById(int id);

        Patient AddPatient(Patient patient);

        Patient UpdatePatient(int id, Patient patient);

        void DeletePatient(int id);
    }
}
