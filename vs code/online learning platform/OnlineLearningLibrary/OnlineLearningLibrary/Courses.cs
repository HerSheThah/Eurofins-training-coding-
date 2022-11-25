using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OnlineLearningLibrary
{
    public class Courses
    {
        [Key]
        public int courseid { get; set; }
        public string coursename { get; set; }
        public float price { get; set; }
        public int rating { get; set; }

        public Department department { get; set; }
        public int deptid { get; set; }
        public Instructor instructor { get; set; }
        public int instructorid { get; set; }


        public Courses() { }
        public Courses(string coursename, float price, int rating,int deptid,int instructorid)
        {
            this.coursename = coursename;
            this.price = price;
            this.rating = rating;
            this.deptid = deptid;
            this.instructorid = instructorid;
        }
    }
}
