using Solid.Core.Entities;


namespace Solid.Core.Services
{
    public interface IAppointmentService
    {
        List<Appointment> GetAppointment();

        Appointment GetById(int id);

        Appointment AddAppointment(Appointment appointment);

        Appointment UpdateAppointment(int id, Appointment appointment);

        void DeleteAppointment(int id);
    }
}
