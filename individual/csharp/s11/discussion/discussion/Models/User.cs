using System.ComponentModel.DataAnnotations;

namespace discussion.Models
{
    public class User
    {
        [Key] //
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
        [Display(Name = "Registration Date")]
        [DisplayFormat(DataFormatString = "{0:yyyy-MM-dd}", ApplyFormatInEditMode = true)]
        [DataType(DataType.Date)]
        public DateTime RegistrationDate { get; set; }

        [Required]
        [Display(Name = "Is Admin")]
        public bool IsAdmin { get; set; }


    }
}
