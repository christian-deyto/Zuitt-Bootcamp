namespace Web_App.Models
{
    public class Product
    {

        public int Id { get; set; }
        public string Name { get; set; } = null!;
        public int Price { get; set; }
        public string Description { get; set; } = null!;
        public Product(int id, string name, int price, string description)
        {
            Id = id;
            Name = name;
            Price = price;
            Description = description;
        }
    }
}
