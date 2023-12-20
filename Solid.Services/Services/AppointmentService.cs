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

        public void AddAppointment(Appointment appointment)
        {
            _appointmentRepository.AddAppointment(appointment);
        }

        public void DeleteAppointment(int id)
        {
            _appointmentRepository.DeleteAppointment(id);
        }

        public List<Appointment> GetAppointment()
        {
            return _appointmentRepository.GetAppointment();
        }

        public Appointment GetById(int id)
        {
            return _appointmentRepository.GetById(id);
        }

        public void UpdateAppointment(int id, Appointment appointment)
        {
            _appointmentRepository.UpdateAppointment(id, appointment);
        }

    }
}
