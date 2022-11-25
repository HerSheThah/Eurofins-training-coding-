using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OnlineLearningLibrary
{
    public class Instructor
    {
        [Key]
        public int instructorid { get; set; }
        public string fname { get; set; }
        public string lname { get; set; }
        public string sex { get; set; }
        public int age { get; set; }
        public int yrsOfExp { get; set; }

        public Instructor() { }
        public Instructor(string fname, string lname, string sex, int age, int yrsOfExp)
        {
            this.fname = fname;
            this.lname = lname;
            this.sex = sex;
            this.age = age;
            this.yrsOfExp = yrsOfExp;
        }

    }
}
