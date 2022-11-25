using System;
using System.Collections.Generic;

namespace Restaurantmanagementlibrary.Models
{
    public partial class Customer
    {
        public Customer()
        {
            Dineins = new HashSet<Dinein>();
            Orders = new HashSet<Order>();
        }

        public int Custid { get; set; }
        public string? Fname { get; set; }
        public string? Lname { get; set; }
        public string? Sex { get; set; }
        public DateTime? Dob { get; set; }
        public int? Age { get; set; }
        public long? Phno { get; set; }

        public Customer(int custid, string? fname, string? lname, string? sex, DateTime? dob, int? age, long? phno) {
            Custid = custid;
            Fname = fname;
            Lname = lname;
            Sex = sex;
            Dob = dob;
            Age = age;
            Phno = phno;
          
        }

        public virtual ICollection<Dinein> Dineins { get; set; }
        public virtual ICollection<Order> Orders { get; set; }
    }
}
