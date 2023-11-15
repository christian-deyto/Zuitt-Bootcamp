using System.ComponentModel.DataAnnotations;

namespace discussion.Models
{
    public class Course
    {
        [Key] // Sets the Id as the primary key
        public int Id { get; set; }

        [Required]
        [StringLength(50, MinimumLength = 10)]
        public string Title { get; set; } = null!;

        [Required]
        public Stack Stack { get; set; }

        [Required]
        public string Description { get; set; } = null!;

        [Required]
        [DataType(DataType.Currency)]
        public double Price { get; set; }

        [Required]
        [DataType(DataType.Url)]
        [Display(Name = "Stack Url")]
        public string StackUrl { get; set; } = null!;

        [Required]
        [DataType(DataType.ImageUrl)]
        [Display(Name = "Logo")]
        public string Logo { get; set; } = null!;


    }
}
