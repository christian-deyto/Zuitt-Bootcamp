using Microsoft.EntityFrameworkCore.Metadata.Internal;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Xml.Linq;

namespace LaZuittEcommerce.Models;

public class Course
{
    [Key]
    public int Id { get; set; }

    [Required]
    public string Title { get; set; } = null!;

    [Required]
    public string Description { get; set; } = null!;

    [Required]
    [Column(TypeName = "decimal(6,2)")]
    public decimal Price { get; set; }

    [Display(Name = "Unit")]
    public int Quantity { get; set; }

    [Required]
    [DataType(DataType.ImageUrl)]
    public string Logo { get; set; } = null!;
}