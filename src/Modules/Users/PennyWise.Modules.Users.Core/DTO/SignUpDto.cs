using System.ComponentModel.DataAnnotations;

namespace PennyWise.Modules.Users.Core.DTO;

public class SignUpDto
{
    public Guid Id { get; set; }
    
    [Required]
    [EmailAddress]
    public string Email { get; set; }

    [Required]
    [MinLength(6)]
    public string Password { get; set; }
    public string Name { get; set; }
    public string Lastname { get; set; }
    public string Role { get; set; }
}