using System.ComponentModel.DataAnnotations;

namespace Session_6___ContosoPizza.Models
{
    public class Order
    {
        
        public int Id { get; set; }

        public DateTime OrderPlaced { get; set; }
        public DateTime? OrderFulfilled { get; set; }
        
        // CustomerId repræsentere forign key
        public int CustomerId { get; set; }
        // navigation property, Order har 1 til mange Customers
        public Customer Customer { get; set; } = null!;
        
        // navigation property, Order har 0 til mange OrderDetails
        public ICollection<OrderDetail> OrderDetails { get; set; } = null!;
    }
}