using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Session_7___Aflevering___Models
{
    public class Vare
    {
        [Key]
        [Range(1, int.MaxValue)]
        public int Id { get; set; }

        [Required]
        [MaxLength(50), MinLength(5)]
        public string Name { get; set; }

        [MaxLength(200)]
        public string Description { get; set; }

        [Range(0, 1000)]
        public int? StockAmount { get; set; }

        [Range(1.0, int.MaxValue)]
        public int Price { get; set; }

        // foreign key
        public int VaregruppeId { get; set; }
        // navigation property
        public Varegruppe Varegruppe { get; set; }


        public override string ToString()
        {
            return $"Id: {Id}, Name: {Name}, Description: {Description}, StockAmount: {StockAmount}, Price: {Price}";
        }

    }
}
