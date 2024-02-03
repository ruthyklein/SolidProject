namespace Solid.API.Models
{
    public class ApointmentPostModel
    {
        public DateTime DateTime { get; set; }
        public int DoctorId { get; set; }
        public int PatientId { get; set; }
    }
}
