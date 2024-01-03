using System.ComponentModel.DataAnnotations;

namespace Solid.Core.Entities
{
    public class Appointment
    {
        public int Id { get; }
        public DateTime DateTime { get; set; }
        //public Doctor Doctor { get; set; }
        //public Patient Patient { get; set; }



        public Appointment(int id,DateTime dateTime)
        {
            Id = id;
            DateTime = dateTime;
            //Doctor = doctor;
            //Patient = patient;
        }


    }
}
