using Solid.Core.Entities;
using Solid.Core.Services;
using Solid.Core.Repositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Numerics;

namespace Solid.Data.Repositories
{
    public class PatientRepository : IPatientRepository
    {
        private readonly DataContext _context;

        public PatientRepository(DataContext context)
        {
            _context = context;
        }

        public Patient AddPatient(Patient patient)
        {
            _context.PatientList.Add(patient);
            _context.SaveChanges();
            return patient;
        }

        public void DeletePatient(int id)
        {
            _context.PatientList.Remove(_context.PatientList.Find(id));
            _context.SaveChanges();
        }

        public Patient GetById(int id)
        {
            return _context.PatientList.Find(id);
        }

        public List<Patient> GetPatient()
        {
            return _context.PatientList.ToList();
        }

        public Patient UpdatePatient(int id, Patient patient)
        {
            var updatePatient = _context.PatientList.Find(id);
            updatePatient=patient;
            _context.SaveChanges();
            return updatePatient;
          
        }
    }
}
