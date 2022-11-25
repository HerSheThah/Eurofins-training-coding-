using System;
using System.Collections.Generic;

namespace MVC_EFexample.Models
{
    public partial class DepartmentTable
    {
        public DepartmentTable()
        {
            EmployeeTables = new HashSet<EmployeeTable>();
        }

        public long Deptid { get; set; }
        public string? Deptname { get; set; }

        public virtual ICollection<EmployeeTable> EmployeeTables { get; set; }
    }
}
