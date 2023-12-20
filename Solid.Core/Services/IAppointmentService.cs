using Solid.Core.Entities;


namespace Solid.Core.Services
{
    public interface IAppointmentService
    {
        List<Appointment> GetAppointment();

        Appointment GetById(int id);

        void AddAppointment(Appointment appointment);

        void UpdateAppointment(int id, Appointment appointment);

        void DeleteAppointment(int id);
    }
}
