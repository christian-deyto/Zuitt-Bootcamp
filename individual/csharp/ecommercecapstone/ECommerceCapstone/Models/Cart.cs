namespace ECommerceCapstone.Models.ViewModels;

public class Cart
{
    public List<CartItem> CartItems { get; set; }
    public decimal TotalAmount { get; set; }
}