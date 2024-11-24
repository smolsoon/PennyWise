namespace PennyWise.Modules.Users.Core.DTO;

public class UserDto
{
    public Guid Id { get; set; }
    public string Email { get; set; }
    public string Role { get; set; }
    public DateTime CreatedAt { get; set; }

    public UserDto(Guid id, string email, string role, DateTime createdAt)
    {
        Id = id;
        Email = email;
        Role = role;
        CreatedAt = createdAt;
    }
}