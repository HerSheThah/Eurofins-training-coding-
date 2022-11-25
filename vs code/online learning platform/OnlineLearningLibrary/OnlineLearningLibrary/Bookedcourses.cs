using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OnlineLearningLibrary
{
    internal class Bookedcourses
    {
        [Key]
        public int bookingid { get; set; }
        public DateTime dateofEnroll { get; set; }
        public DateTime dateofexp { get; set; }

        public Courses courses { get; set; }
        public int courseid { get; set; }

        public Students students { get; set; }
        public int stuid { get; set; }

    }
}
