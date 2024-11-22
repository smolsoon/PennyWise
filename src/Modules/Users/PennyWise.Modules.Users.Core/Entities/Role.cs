namespace PennyWise.Modules.Users.Core.Entities;

internal class Role
{
    public string Name { get; set; }
    public IEnumerable<string> Permisions { get; set; }
    public IEnumerable<User> Users { get; set; }

    private const string User = "user";
    public const string Admin = "admin";
    public static string Default => User;
}