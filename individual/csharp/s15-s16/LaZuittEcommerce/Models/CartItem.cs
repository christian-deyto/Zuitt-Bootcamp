namespace LaZuittEcommerce.Models;

public class CartItem
{
    public int CourseId { get; set; }
    public string Icon { get; set; }
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

    public CartItem(Course course)
    {
        CourseId = course.Id;
        Icon = course.Logo;
        Title = course.Title;
        Description = course.Description;
        Price = course.Price;
        Quantity = 1;
    }
}