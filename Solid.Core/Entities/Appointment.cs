namespace Solid.Core.Entities
{
    public class Appointment
    {
        public int Id { get; }
        public DateTime DateTime { get; set; }
        public Doctor Doctor { get; set; }
        public Patient Patient { get; set; }

        private static int count;

        public Appointment(DateTime dateTime, Doctor doctor, Patient patient)
        {
            Id = ++count;
            DateTime = dateTime;
            Doctor = doctor;
            Patient = patient;
        }

        public Appointment()
        {
            Id = ++count;
        }

    }
}
