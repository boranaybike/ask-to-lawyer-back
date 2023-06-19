using Application.Features.Login;
using Microsoft.AspNetCore.Mvc;

namespace WebApi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class AuthenticationController : ApiControllerBase
    {

        [HttpPost("Login")]
        public async Task<IActionResult> LoginAsync(LoginCommand command)
        {
            return Ok(await Mediator.Send(command));
        }

    }
}
