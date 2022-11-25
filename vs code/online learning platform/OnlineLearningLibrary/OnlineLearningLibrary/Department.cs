using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OnlineLearningLibrary
{
    public  class Department
    {
        [Key]
        public int deptid { get; set; }
        public string deptname { get; set; }
    }
}
