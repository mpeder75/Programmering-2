﻿// <auto-generated> This file has been auto generated by EF Core Power Tools. </auto-generated>
#nullable disable
using System;
using System.Collections.Generic;

namespace Session_8___test.Models
{
    public partial class Department
    {
        public int DepartmentId { get; set; }
        public int? DepartmentNumber { get; set; }
        public string DepartmentName { get; set; }
        public int? CompanyId { get; set; }

        public virtual Company Company { get; set; }
    }
}