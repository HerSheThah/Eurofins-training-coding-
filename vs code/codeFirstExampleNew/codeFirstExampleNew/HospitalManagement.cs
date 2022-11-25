using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace codeFirstExampleNew
{
    internal class HospitalManagementContext:DbContext
    {
        private const string connectionString = "Server=(localdb)\\mssqllocaldb;Database=HospitalDB;Trusted_Connection=True;";
        public HospitalManagementContext() { }
        public HospitalManagementContext(DbContextOptions options) : base(options)
        {
        }
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer(connectionString);
        }

        public DbSet<DoctorDetails> Doctors { get; set; }
        public DbSet<PatientDetails> Patients { get; set; }

    }
}
