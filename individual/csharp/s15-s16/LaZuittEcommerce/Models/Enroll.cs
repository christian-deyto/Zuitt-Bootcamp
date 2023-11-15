using System.ComponentModel.DataAnnotations;
using System.Xml.Linq;

namespace LaZuittEcommerce.Models;

public class Enroll
{
    [Key]
    public int Id { get; set; }

    public int StudentId { get; set; }
    public virtual Student Student { get; set; } = null!;

    [Display(Name = "Enroll Date")]
    [DisplayFormat(DataFormatString = "{0:yyyy-MM-dd}", ApplyFormatInEditMode = true)]
    [DataType(DataType.Date)]
    public DateTime EnrollDate { get; set; }
}

