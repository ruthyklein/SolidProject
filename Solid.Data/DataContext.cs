using CsvHelper;
using Solid.Core.Entities;
using System.Diagnostics.Metrics;
using System.Globalization;
using static System.Reflection.Metadata.BlobBuilder;

namespace Solid.Data
{
    public class DataContext
    {
        public List<Appointment> AppointmentList { get; set; }
        public List<Doctor> DoctorList { get; set; }
        public List<Patient> PatientList { get; set; }

        public DataContext()
        {
            AppointmentList = new List<Appointment>
            {
                 new Appointment {DateTime = new DateTime(2022,12,03),Doctor=new Doctor(),Patient=new Patient()},
                 new Appointment {DateTime = new DateTime(2022,11,03),Doctor=new Doctor(),Patient=new Patient()},
                 new Appointment {DateTime = new DateTime(2022,12,04),Doctor=new Doctor(),Patient=new Patient()}
             };
            DoctorList = new List<Doctor>
            {
                 new Doctor { Name = "John Doe",Address="Jerusalem 1",DateBorn=new DateTime(),PhoneNumber="123456",Status=true},
                 new Doctor { Name = "Rafi Levin",Address="Verner 18",DateBorn=new DateTime(),PhoneNumber="123456",Status=true},
                 new Doctor { Name = "Itzik Rendel",Address="Belze 8",DateBorn=new DateTime(),PhoneNumber="123456",Status=true}

            };

            PatientList = new List<Patient>
            {
                 new Patient { Name = "David",Address="Jerusalem 1",DateBorn=new DateTime(),PhoneNumber="123456",Status=true},
                 new Patient { Name = "Ruth",Address="Jerusalem 1",DateBorn=new DateTime(),PhoneNumber="123456",Status=true},
                 new Patient { Name = "Shevi",Address="Jerusalem 1",DateBorn=new DateTime(),PhoneNumber="123456",Status=true}
            };
            //AppointmentList = new List<Appointment>();
            //DoctorList = new List<Doctor>();
            //PatientList = new List<Patient>();

            //using (var reader = new StreamReader("data.csv"))
            //using (var csv = new CsvReader(reader, CultureInfo.InvariantCulture))
            //{
            //    AppointmentList = csv.GetRecords<Appointment>().ToList();
            //    DoctorList = csv.GetRecords<Doctor>().ToList();
            //    PatientList = csv.GetRecords<Patient>().ToList();
            //}

        }
    }
}
