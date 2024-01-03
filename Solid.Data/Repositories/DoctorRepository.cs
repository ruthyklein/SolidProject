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

        public Doctor AddDoctor(Doctor doctor)
        {
            _context.DoctorList.Add(doctor);
            _context.SaveChanges();
            return doctor;

        }

        public void DeleteDoctor(int id)
        {
            _context.DoctorList.Remove(_context.DoctorList.Find(id));
            _context.SaveChanges();
        }

        public Doctor GetById(int id)
        {

            return _context.DoctorList.Find(id);
        }

        public List<Doctor> GetDoctor()
        {
            return _context.DoctorList.ToList();
        }

        public Doctor UpdateDoctor(int id, Doctor doctor)
        {

            var updateDoctor = _context.DoctorList.Find(id);
            updateDoctor=doctor;
            _context.SaveChanges();
            return updateDoctor;
        }
   
    }
}
