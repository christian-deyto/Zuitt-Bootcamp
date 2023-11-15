using System.ComponentModel.DataAnnotations;

namespace course_booking_cs.Models
{
    public class User
    {
        public int Id { get; set; }
        public string? FirstName { get; set; }
        public string? LastName { get; set; }
        public string? Email { get; set; }
        public string? Password { get; set; }
        public bool? IsAdmin { get; set; }
    }

    public class UserloginDTO
    {
        [Required]
        [EmailAddress]
        public string? Email { get; set; }

        [Required]
        public string? Password { get; set; }
    }

    public class UserRegisterDTO
    {
        [Required]
        public string? FirstName { get; set; }

        [Required]
        public string? LastName { get; set; }

        [Required]
        [EmailAddress]
        public string? Email { get; set; }

        [Required]
        public string? Password { get; set; }

        public bool IsAdmin { get; set; }
    }

    public class LoginResponse
    {
        public string? email { get; set; }
        public bool? isAdmin { get; set; }
        public int? token { get; set; }
    }

}

