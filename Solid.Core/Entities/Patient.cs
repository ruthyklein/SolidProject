using System.ComponentModel.DataAnnotations;

namespace Solid.Core.Entities
{
    public class Patient
    {
        private static int count;
        [Key]
        public int IdNumber { get; }
        public string Name { get; set; }
        public DateTime DateBorn { get; set; }
        public string Address { get; set; }
        public string PhoneNumber { get; set; }
        public bool Status { get; set; }


        public Patient(string name, DateTime dateBorn, string address, string phoneNumber, bool status)
        {
            IdNumber = ++count;
            Name = name;
            DateBorn = dateBorn;
            Address = address;
            PhoneNumber = phoneNumber;
            Status = status;
        }


        public Patient()
        {
            IdNumber = ++count;
        }

    }
}
