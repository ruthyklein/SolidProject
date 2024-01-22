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

        public async Task<Doctor> AddDoctorAsync(Doctor doctor)
        {
            return await _doctorRepository.AddDoctorAsync(doctor);
        }

        public async Task DeleteDoctorAsync(int id)
        {
            await _doctorRepository.DeleteDoctorAsync(id);
        }

        public async Task<IEnumerable<Doctor>> GetDoctorAsync()
        {
            return await _doctorRepository.GetDoctorAsync();
        }

        public async Task<Doctor> GetByIdAsync(int id)
        {
            return await _doctorRepository.GetByIdAsync(id);
        }

        public async Task<Doctor> UpdateDoctorAsync(int id, Doctor doctor)
        {
            return await _doctorRepository.UpdateDoctorAsync(id, doctor);
        }

    }
}
