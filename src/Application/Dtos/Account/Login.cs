using System.ComponentModel.DataAnnotations;

namespace Application.Dtos.Account
{
    public class Login
    {
        [Required]
        [EmailAddress]
        public required string Email { get; set; }

        [Required]
        public required string Password { get; set; }
    }
}