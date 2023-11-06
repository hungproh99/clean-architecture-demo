using System.ComponentModel.DataAnnotations;

namespace Application.Dtos.Account
{
    public class AssignRolesDto
    {
        [Required]
        public required string UserId { get; set; }

        [Required]
        public required string Role { get; set; }
    }
}