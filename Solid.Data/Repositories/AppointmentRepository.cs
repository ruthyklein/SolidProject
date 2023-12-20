using Solid.Core.Entities;
using Solid.Core.Repositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Solid.Data.Repositories
{
    public class AppointmentRepository : IAppointmentRepository
    {
        private readonly DataContext _context;

        public AppointmentRepository(DataContext context)
        {
            _context = context;
        }

        public Appointment AddAppointment(Appointment appointment)
        {
            _context.AppointmentList.Add(appointment);
            return appointment;
        }

        public void DeleteAppointment(int id)
        {
            _context.AppointmentList.Remove(_context.AppointmentList.Find(u => u.Id== id));
        }

        public Appointment GetById(int id)
        {
            return _context.AppointmentList.Find(u => u.Id == id);
        }

        public List<Appointment> GetAppointment()
        {
            return _context.AppointmentList;
        }

        public Appointment UpdateAppointment(int id, Appointment appointment)
        {
            var updateAppointment = _context.AppointmentList.Find(u => u.Id == id);
            if (updateAppointment != null)
            {
                updateAppointment.Patient = appointment.Patient;
                
                return updateAppointment;
            }
            return null;

        }
    }
    
}
