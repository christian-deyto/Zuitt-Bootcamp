namespace ECommerceCapstone.Models
{
    public class CartItem
    {
        public int ProductId { get; set; } 
        public string Title { get; set; }
        public string Description { get; set; }
        public decimal Price { get; set; }
        public int Quantity { get; set; }
        public decimal TotalAmount
        {
            get { return Quantity * Price; }
        }

        public CartItem()
        {
        }

        public CartItem(Product product) 
        {
            ProductId = product.Id; 
            Title = product.Name; 
            Description = product.Description;
            Price = product.Price;
            Quantity = product.Quantity;
        }
    }
}
