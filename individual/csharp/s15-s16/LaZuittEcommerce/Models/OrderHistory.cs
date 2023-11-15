using System.Data;

namespace LaZuittEcommerce.Models
{
    public class OrderHistory
    {
        public int Id { get; set; }
        public string FullName { get; set; } = null!;
        public string Billing { get; set; } = null!;
        public DateTime DateEnrolled { get; set; }
        public string Title { get; set; } = null!;
        public string Description { get; set; } = null!;
        public decimal Price { get; set; }
        public int Quantity { get; set; }
    }
}
