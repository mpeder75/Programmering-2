using System;
using System.Collections.Generic;

namespace Session_8___EFC_scaffolding_manuelt.Models
{
    public partial class PhoneNumber
    {
        public int PhoneNumberId { get; set; }
        public int? EmployeeId { get; set; }
        public int? PhoneNumber1 { get; set; }

        public virtual Employee? Employee { get; set; }
    }
}
