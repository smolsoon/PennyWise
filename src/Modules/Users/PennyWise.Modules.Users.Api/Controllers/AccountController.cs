using Microsoft.AspNetCore.Mvc;
using PennyWise.Modules.Users.Core.DTO;
using PennyWise.Modules.Users.Core.Services;

namespace PennyWise.Modules.Users.Api.Controllers;

public class AccountController(IUserService userService) : BaseController
{
    [HttpGet]
    public async Task<ActionResult<UserDto?>> GetAsync(Guid id)
    {
        var user = await userService.GetAsync(id);

        return OkOrNotFound(user);
    }
    
    [HttpGet("users")]
    public async Task<ActionResult<IEnumerable<UserDto?>>> BrowseAsync()
    {
        var user = await userService.BrowseAsync();

        return Ok(user); 
    }
    
    [HttpPost("sign-up")]
    public async Task<ActionResult> SignUpAsync(SignUpDto signUpDto)
    {
        await userService.SignUpAsync(signUpDto);

        return NoContent();
    }
}