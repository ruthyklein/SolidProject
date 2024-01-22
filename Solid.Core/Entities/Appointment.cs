using System.ComponentModel.DataAnnotations;

namespace Solid.Core.Entities
{
    public class Appointment
    {
        public int Id { get; set; }
        public DateTime DateTime { get; set; }
        public List<Doctor> Doctor { get; set; }
        public List<Patient> Patient { get; set; }

        //public Appointment(int id, DateTime dateTime)
        //{
        //    Id = id;
        //    DateTime = dateTime;
        //}
 
    }
}
