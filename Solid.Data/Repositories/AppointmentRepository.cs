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
    public class AppointmentRepository : IAppointmentRepository
    {
        private readonly DataContext _context;

        public AppointmentRepository(DataContext context)
        {
            _context = context;
        }

        public async Task<Appointment> AddAppointmentAsync(Appointment appointment)
        {
            _context.AppointmentList.Add(appointment);
            await _context.SaveChangesAsync();
            return appointment;
        }
   

        public async Task DeleteAppointmentAsync(int id)
        {
            _context.AppointmentList.Remove(_context.AppointmentList.Find(id));
            await _context.SaveChangesAsync();
        }

        public async Task<Appointment> GetByIdAsync(int id)
        {
            return _context.AppointmentList.Find(id);
        }

        public async Task<List<Appointment>> GetAppointmentAsync()
        {
            return await _context.AppointmentList.Include(u=>u.Doctor).Include(p=>p.Patient).ToListAsync();
        }

        public async Task<Appointment> UpdateAppointmentAsync(int id, Appointment appointment)
        {
            var updateAppointment = _context.AppointmentList.Find(id);
            updateAppointment = appointment;
            await _context.SaveChangesAsync();
            return updateAppointment;
        }
    }
    
}
