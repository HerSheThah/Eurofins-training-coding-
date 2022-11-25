using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OnlineLearningLibrary
{
    internal class Students
    {
        [Key]
        public int studentid { get; set; }
        public string fname { get; set; }
        public string lname { get; set; }
        public string gender { get; set; }
        public int age { get; set; }
        public long phno { get; set; }
    }
}
