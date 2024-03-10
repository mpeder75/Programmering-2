using System.ComponentModel.DataAnnotations;

namespace Session_6___ContosoPizza.Models
{
    // OrderDetail facilitere mange til mange relationship

    public class OrderDetail
    {
        
        public int Id { get; set; }
        public int Quantity { get; set; }
        
        // forign keys 
        public int ProductId { get; set; }
        public int OdreId { get; set; }
        // naavgation properties
        public Order Order { get; set; }
        public Product Product{ get; set; }
    }
}