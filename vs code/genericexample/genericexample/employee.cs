using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace genericexample
{
    internal class Employee
    {
        public int eid { get; set; }
        public string ename { get; set; }
        public float salary { get; set; }

        public Employee() { }

        public Employee(int _eid, string _ename, float _salary)
        {
            eid = _eid;
            ename = _ename;
            salary = _salary;
        }

        public override string ToString()
        {
            return "Eid: " + eid + " Ename: " + ename + " Salary: " + salary;
        }
    }
}
