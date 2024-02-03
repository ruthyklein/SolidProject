using Microsoft.EntityFrameworkCore;
using Solid.Core.Entities;
using Solid.Core.Repositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Solid.Data.Repositories
{
    public class DoctorRepository : IDoctorRepository
    {
        private readonly DataContext _context;

        public DoctorRepository(DataContext context)
        {
            _context = context;
        }

        public async Task<Doctor> AddDoctorAsync(Doctor doctor)
        {
            _context.DoctorList.Add(doctor);
            await _context.SaveChangesAsync();
            return doctor;

        }

        public async Task DeleteDoctorAsync(int id)
        {
            _context.DoctorList.Remove(_context.DoctorList.Find(id));
            await _context.SaveChangesAsync();
        }

        public async Task<Doctor> GetByIdAsync(int id)
        {

            return _context.DoctorList.Find(id);
        }

        public async Task<IEnumerable<Doctor>> GetDoctorAsync()
        {
            return await _context.DoctorList.ToListAsync();
        }

        public async Task<Doctor> UpdateDoctorAsync(int id, Doctor doctor)
        {

            var updateDoctor = _context.DoctorList.Find(id);
            updateDoctor=doctor;
            await _context.SaveChangesAsync();
            return updateDoctor;
        }
   
    }
}
