using System;
using System.Collections.Generic;

namespace Session_8___EFC_scaffolding_manuelt.Models
{
    public partial class City
    {
        public City()
        {
            Addresses = new HashSet<Address>();
        }

        public int PostalCode { get; set; }
        public string? City1 { get; set; }

        public virtual ICollection<Address> Addresses { get; set; }
    }
}
