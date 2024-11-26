using Microsoft.IdentityModel.JsonWebTokens;
using PennyWise.Modules.Users.Core.DTO;

namespace PennyWise.Modules.Users.Core.Services;

public interface IUserService
{
    Task<UserDto?> GetAsync(Guid id);
    Task<IEnumerable<UserDto>> BrowseAsync();
    Task<JsonWebToken> SignInAsync(SignInDto signInDto);
    Task SignUpAsync(SignUpDto signUpDto);
}