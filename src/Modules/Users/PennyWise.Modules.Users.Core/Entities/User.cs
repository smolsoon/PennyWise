namespace PennyWise.Modules.Users.Core.Entities;

internal class User
{
    public Guid Id { get; set; }
    public string Email { get; set; }
    public string Password { get; set; }
    public Role Role { get; set; }
    public string RoleId { get; set; }
    public DateTime CreatedAt { get; set; }
}