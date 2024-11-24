namespace PennyWise.Modules.Users.Core.Entities;

internal class User
{
    public Guid Id { get; set; }
    public string Name { get; set; }
    public string Lastname { get; set; }
    public string Email { get; set; }
    public string Password { get; set; }
    public string Role { get; set; }
    public bool IsActive { get; set; }
    public DateTime CreatedAt { get; set; }

    public User(string name, string lastname, string email, string password, string role)
    {
        Id = Guid.NewGuid();
        Name = name;
        Lastname = lastname;
        Email = email;
        Password = password;
        Role = role;
        CreatedAt = DateTime.UtcNow;
    }
}
