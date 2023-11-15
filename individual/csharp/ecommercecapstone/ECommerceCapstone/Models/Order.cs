namespace ECommerceCapstone.Models
{
    public class Order
    {
        public int Id { get; set; }
        public List<Product> Products { get; set; } = null!;
        public string UserId { get; set; } = null!;
        public DateTime OrderDate { get; set; }
    }
}
