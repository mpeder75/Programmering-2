using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Session_6___ContosoPizza.Models
{
    public class Product
    {
             
        public int Id { get; set; }

        // =null! gør at Name initializers til at være null til at starte med
        public string Name { get; set; } = null!;

        // Her defineres decimal til en præcision på 2 decimaler
        [Column(TypeName = "decimal(6,2)")]
        public decimal Price { get; set; }

    }
}
