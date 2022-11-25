using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;

namespace MVC_EFexample.Models
{
    public partial class Worker
    {
        public int Worderid { get; set; }
        public string? Fname { get; set; }
        public string? Lname { get; set; }
        public int? Salary { get; set; }
        public DateTime? Joiningdate { get; set; }
        public string? Dept { get; set; }

        public string Password { get; set; }
        [NotMapped]
        public string? ConfirmPassword { get; set; }
    }
}
