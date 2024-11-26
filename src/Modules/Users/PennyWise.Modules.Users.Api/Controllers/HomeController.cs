using Microsoft.AspNetCore.Mvc;

namespace PennyWise.Modules.Users.Api.Controllers;


[Route("api/[controller]")]
[ApiController]
public class HomeController : ControllerBase
{
    [HttpGet]
    public ActionResult GetPennyWise()
    {
        return Ok("Hello PennyWise!");
    }
}
