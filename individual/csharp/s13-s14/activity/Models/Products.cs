namespace activity.Models
{
    public class Products
    {
        public int Id { get; set; }

        public string ProductName { get; set; } = null!;

        public string Category { get; set; } = null!;

        public string Description { get; set; } = null!;

        public int Price { get; set; }

        public string Productimg { get; set; } = null!;
    }
}
