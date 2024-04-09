using System;
using System.Collections.Generic;

namespace Session_8___EFC_scaffolding_manuelt.Models
{
    public partial class Address
    {
        public int AddressId { get; set; }
        public string? AddressLine { get; set; }
        public int? PostalCode { get; set; }
        public int? EmployeeId { get; set; }

        public virtual Employee? Employee { get; set; }
        public virtual City? PostalCodeNavigation { get; set; }
    }
}
