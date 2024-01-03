using System.ComponentModel.DataAnnotations;

namespace Solid.Core.Entities
{
    public class Doctor
    {
        public int Id { get; }
        public string Name { get; set; }
        public DateTime DateBorn { get; set; }
        public string Address { get; set; }
        public string PhoneNumber { get; set; }
        public bool Status { get; set; }

        public Doctor(int id,string name, DateTime dateBorn, string address, string phoneNumber)
        {
            Id = id;
            Name = name;
            DateBorn = dateBorn;
            Address = address;
            PhoneNumber = phoneNumber;
        }


    }
}
