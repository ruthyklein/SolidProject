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
    public class AppointmentService : IAppointmentService
    { 
        private readonly IAppointmentRepository _appointmentRepository;

        public AppointmentService(IAppointmentRepository appointmentRepository)
            {
              _appointmentRepository = appointmentRepository;
            }

        public async Task<Appointment> AddAppointmentAsync(Appointment appointment)
        {
            return await _appointmentRepository.AddAppointmentAsync(appointment);
        }

        public async Task DeleteAppointmentAsync(int id)
        {
             await _appointmentRepository.DeleteAppointmentAsync(id);
        }

        public async Task<List<Appointment>> GetAppointmentAsync()
        {
            return await _appointmentRepository.GetAppointmentAsync();
        }

        public async Task<Appointment> GetByIdAsync(int id)
        {
            return await _appointmentRepository.GetByIdAsync(id);
        }

        public async Task<Appointment> UpdateAppointmentAsync(int id, Appointment appointment)
        {
            return await _appointmentRepository.UpdateAppointmentAsync(id, appointment);
        }

    }
}
