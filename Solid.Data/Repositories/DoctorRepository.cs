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
            return doctor;
        }

        public void DeleteDoctor(int id)
        {
            _context.DoctorList.Remove(_context.DoctorList.ToList().Find(u => u.Id == id));
        }

        public Doctor GetById(int id)
        {
            return _context.DoctorList.ToList().Find(u => u.Id == id);
        }

        public List<Doctor> GetDoctor()
        {
            return _context.DoctorList.ToList();
        }

        public Doctor UpdateDoctor(int id, Doctor doctor)
        {
            var updateDoctor = _context.DoctorList.ToList().Find(u => u.Id == id);
            if (updateDoctor != null)
            {
                updateDoctor.Address= doctor.Address;

                return updateDoctor;
            }
            return null;
        }
   
    }
}
