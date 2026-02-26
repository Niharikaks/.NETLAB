using System.ComponentModel.DataAnnotations;

namespace registration.Models
{
    public class Register
    {
      

        [Required(ErrorMessage = "Username is required")]
        [RegularExpression(@"^[A-Za-z]+$",
            ErrorMessage = "name must contain only aplhabets")]

        public required string Name { get; set; }
        [Required(ErrorMessage = "Email is required")]
        [EmailAddress(ErrorMessage = "Invalid email address")]

        public required string Email { get; set; }

        [Required(ErrorMessage = "Password is required")]
        [RegularExpression(
            @"^(?=.*[a-z])(?=.*[A-Z])(?=.*\d)(?=.*[@$!%*?&]).{8,}$",
            ErrorMessage = "Password must be at least 8 characters long and contain at least one uppercase letter, one lowercase letter, one digit, and one special character")]
        [MinLength(8, ErrorMessage = "Password must be at least 8 characters long")]

        public required string Password { get; set; }
        
        [Required(ErrorMessage="age is required")]
        [Range(18, 100, ErrorMessage = "Age must be between 18 and 100")]

        public int Age { get; set; }
    }
}
