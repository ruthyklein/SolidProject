using System.ComponentModel.DataAnnotations;

namespace Solid.Core.Entities
{
    public class Patient
    {
        public int Id { get;set; }
        public string Name { get; set; }
        public DateTime DateBorn { get; set; }
        public string Address { get; set; }
        public string PhoneNumber { get; set; }
        public bool Status { get; set; }
        public int AppointmentId { get; set; }
        public Appointment Appointment { get; set; }

        //public Patient(int id, string name, DateTime dateBorn, string address, string phoneNumber, bool status)
        //{
        //    Id = id;
        //    Name = name;
        //    DateBorn = dateBorn;
        //    Address = address;
        //    PhoneNumber = phoneNumber;
        //    Status = status;
        //}



    }
}
