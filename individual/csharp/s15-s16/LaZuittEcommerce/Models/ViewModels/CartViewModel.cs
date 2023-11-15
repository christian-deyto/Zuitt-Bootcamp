using System;
namespace LaZuittEcommerce.Models.ViewModels;

public class CartViewModel
{
    public List<CartItem> CartItems { get; set; }
    public decimal TotalAmount { get; set; }
}