using System;
using System.Collections.Generic;

namespace FirstAPIProj.Models
{
    public partial class EmployeeTable
    {
        public int Empid { get; set; }
        public string? Empname { get; set; }
        public long? Deptid { get; set; }

        public virtual DepartmentTable? Dept { get; set; }
    }
}
