using System.ComponentModel.DataAnnotations;
using System.Xml.Linq;

namespace LaZuittEcommerce.Models;

public class Student
{
    [Key]
    public int Id { get; set; }

    [Required]
    [Display(Name = "First Name")]
    public string FirstName { get; set; } = null!;

    [Required]
    [Display(Name = "Last Name")]
    public string LastName { get; set; } = null!;

    [Required]
    public string Email { get; set; } = null!;

    [Required]
    [Display(Name = "Billing Address")]
    public string BillingAddress { get; set; } = null!;
}