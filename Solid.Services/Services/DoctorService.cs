using Solid.Core.Entities;
using Solid.Core.Repositories;
using Solid.Core.Services;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Solid.Service.Services
{
    public class DoctorService : IDoctorService
    {
        private readonly IDoctorRepository _doctorRepository;

        public DoctorService(IDoctorRepository doctorRepository)
        {
            _doctorRepository = doctorRepository;
        }


        public void AddDoctor(Doctor doctor)
        {
            _doctorRepository.AddDoctor(doctor);
        }

        public void DeleteDoctor(int id)
        {
            _doctorRepository.DeleteDoctor(id);
        }

        public List<Doctor> GetDoctor()
        {
            return _doctorRepository.GetDoctor();
        }

        public Doctor GetById(int id)
        {
            return _doctorRepository.GetById(id);
        }

        public void UpdateDoctor(int id, Doctor doctor)
        {
            _doctorRepository.UpdateDoctor(id, doctor);
        }

    }
}
