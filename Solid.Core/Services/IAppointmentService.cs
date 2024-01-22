using Solid.Core.Entities;


namespace Solid.Core.Services
{
    public interface IAppointmentService
    {
        Task<List<Appointment>> GetAppointmentAsync();

        Task<Appointment> GetByIdAsync(int id);

        Task<Appointment> AddAppointmentAsync(Appointment appointment);

        Task<Appointment> UpdateAppointmentAsync(int id, Appointment appointment);

        Task DeleteAppointmentAsync(int id);
    }
}
