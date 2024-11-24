using System.ComponentModel.DataAnnotations;

namespace PennyWise.Modules.Users.Core.DTO;

public class SignUpDto
{
    public Guid Id { get; set; }
    
    [EmailAddress]
    [Required]
    public string Email { get; set; }
    
    [Required]
    public string Password { get; set; }
    public string Name { get; set; }
    public string Lastname { get; set; }
    
    public string Role { get; set; }
}