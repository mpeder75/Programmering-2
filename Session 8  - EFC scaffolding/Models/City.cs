﻿// <auto-generated> This file has been auto generated by EF Core Power Tools. </auto-generated>
#nullable disable
using System;
using System.Collections.Generic;

namespace Session_8____EFC_scaffolding.Models
{
    public partial class City
    {
        public City()
        {
            Addresses = new HashSet<Address>();
        }

        public int PostalCode { get; set; }
        public string City1 { get; set; }

        public virtual ICollection<Address> Addresses { get; set; }
    }
}