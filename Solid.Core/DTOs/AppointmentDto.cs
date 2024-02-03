using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Solid.Core.DTOs
{
    public class AppointmentDto
    {
        public int Id { get; set; }
        public DateTime DateTime { get; set; }
        public int DoctorId { get; set; }
        public int PatientId { get; set; }
    }
}
