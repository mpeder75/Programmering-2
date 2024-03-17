using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Session_7___Aflevering___Models
{
    public class Varegruppe
    {
        public Varegruppe() 
        {
            Varer = new List<Vare>();
        }

        [Key]
        [Range(1, int.MaxValue)]
        public int Id { get; set; }

        [Required]
        [MaxLength(50)]
        public string Name { get; set; }

        [MaxLength(200)]
        public string? Description { get; set; }

        // navigation property
        public List<Vare> Varer { get; set;}


        public override string ToString()
        {
            return $"Id: {Id}, Name: {Name}, Description: {Description}";
        }
    }
}
