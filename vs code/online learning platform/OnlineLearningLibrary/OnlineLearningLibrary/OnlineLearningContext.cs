using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OnlineLearningLibrary
{
    internal class OnlineLearningContext : DbContext
    {
        private const string connectionString = "Server=(localdb)\\mssqllocaldb;Database=OnlinelearningDB;Trusted_Connection=True;";
        public OnlineLearningContext() { }
        public OnlineLearningContext(DbContextOptions options) : base(options)
        {
        }
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer(connectionString);
        }

        public DbSet<Department> departments { get; set; }
        public DbSet<Courses> Courses { get; set; }
        public DbSet<Bookedcourses> Bookedcourses { get; set; }
        public DbSet<Students> Students { get; set; }
        public DbSet<Instructor> instructors { get; set; }


    }
}
