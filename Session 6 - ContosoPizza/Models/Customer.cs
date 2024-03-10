using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Session_6___ContosoPizza.Models
{
    public class Customer
    {
        // Primary key
        
        public int Id { get; set; }
        public string? FirstName { get; set; } 
        public string? LastName { get; set; }
        public string? Email { get; set; }

        // Address og Phone sættes til nullable (der tillades null)
        public string? Address { get; set; }
        public string? Phone { get; set; }

        // navigation property, indikere en Customer har 0 eller flere Orders
        // Der oprettes derfor en en til mange
        public ICollection<Order> Orders { get; set; } = null!;
    }
}
