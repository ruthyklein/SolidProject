using CsvHelper;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Solid.Core.Entities;
using System.Diagnostics.Metrics;
using System.Globalization;
using static System.Reflection.Metadata.BlobBuilder;

namespace Solid.Data
{
    public class DataContext : DbContext
    {
        private readonly IConfiguration _configuration;

        public DbSet<Appointment> AppointmentList { get; set; }
        public DbSet<Doctor> DoctorList { get; set; }
        public DbSet<Patient> PatientList { get; set; }
        public DataContext(IConfiguration configuration)
        {
            _configuration = configuration;
        }
      
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            if (!optionsBuilder.IsConfigured)
            {
                optionsBuilder.UseSqlServer(_configuration["DbConnectionString"]);
            }
        }

    }
}

