using System;
using System.Collections.Generic;

namespace Session_8___EFC_scaffolding_manuelt.Models
{
    public partial class EmpDepartment
    {
        public int? EmployeeId { get; set; }
        public int? DepartmentId { get; set; }

        public virtual Department? Department { get; set; }
        public virtual Employee? Employee { get; set; }
    }
}
