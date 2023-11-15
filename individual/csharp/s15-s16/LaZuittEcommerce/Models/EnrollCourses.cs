using System.ComponentModel.DataAnnotations;

namespace LaZuittEcommerce.Models;

public class EnrollCourses
{
    [Key]
    public int Id { get; set; }

    public int EnrollId { get; set; }
    public virtual Enroll Enroll { get; set; } = null!;

    public int CourseId { get; set; }
    public virtual Course Course { get; set; } = null!;

    public int Quantity { get; set; }
}