﻿// <auto-generated> This file has been auto generated by EF Core Power Tools. </auto-generated>
#nullable disable
using System;
using System.Collections.Generic;

namespace Session_8___EFC_scaffolding.Models
{
    public partial class EmpDepartment
    {
        public int? EmployeeId { get; set; }
        public int? DepartmentId { get; set; }

        public virtual Department Department { get; set; }
        public virtual Employee Employee { get; set; }
    }
}