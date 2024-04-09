using System;
using System.Collections.Generic;

namespace Session_8___EFC_scaffolding_manuelt.Models
{
    public partial class Email
    {
        public int EmailId { get; set; }
        public int? EmployeeId { get; set; }
        public string? Email1 { get; set; }

        public virtual Employee? Employee { get; set; }
    }
}
