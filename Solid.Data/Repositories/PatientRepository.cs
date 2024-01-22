using Solid.Core.Entities;
using Solid.Core.Services;
using Solid.Core.Repositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Numerics;
using Microsoft.EntityFrameworkCore;

namespace Solid.Data.Repositories
{
    public class PatientRepository : IPatientRepository
    {
        private readonly DataContext _context;

        public PatientRepository(DataContext context)
        {
            _context = context;
        }

        public async Task<Patient> AddPatientAsync(Patient patient)
        {
            _context.PatientList.Add(patient);
            await _context.SaveChangesAsync();
            return patient;
        }

        public async Task DeletePatientAsync(int id)
        {
            _context.PatientList.Remove(_context.PatientList.Find(id));
            await _context.SaveChangesAsync();
        }

        public async Task<Patient> GetByIdAsync(int id)
        {
            return _context.PatientList.Find(id);
        }

        public async Task<IEnumerable<Patient>> GetPatientAsync()
        {
            return await _context.PatientList.Include(p=>p.Appointment).ToListAsync(); ;
        }

        public async Task<Patient> UpdatePatientAsync(int id, Patient patient)
        {
            var updatePatient = _context.PatientList.Find(id);
            updatePatient=patient;
            await _context.SaveChangesAsync();
            return updatePatient;
          
        }
    }
}
