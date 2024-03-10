using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Session_6___EFC___Aflevering.Models
{
    // Hvis proprerty er en kritisk property, skal man ikke tillade null (non-nullable)
    // det er "typisk" properties der modellere en værdi, vægt etc... 

    public class Vare
    {
        public int Id { get; set; }
        [MinLength(2), MaxLength(50)]
        public string? Name { get; set; }
        [MinLength(2), MaxLength(50)]
        public string? Description { get; set; }
        [Range(0.0, int.MaxValue)]
        public int InventoryStatus { get; set; }
        public int Price { get; set; }

        public override string ToString()
        {
            return $"{Id}\n{Name}\n{Description}\n{InventoryStatus}\n{Price}\n{new string('_', 30)}";
        }
    }
}
