namespace PennyWise.Shared.Abstractions.Auth;

public class JsonWebToken
{
    public string AccesToken { get; set; }
    public string RefreshToken { get; set; }
    public long Expires { get; set; }
    public string Id { get; set; }
    public string Email { get; set; }
    
}