using System;
using System.Collections.Generic;

namespace Session_8___EFC_scaffolding_manuelt.Models
{
    public partial class Company
    {
        public Company()
        {
            Departments = new HashSet<Department>();
        }

        public int CompanyId { get; set; }
        public string? CompanyName { get; set; }

        public virtual ICollection<Department> Departments { get; set; }
    }
}
