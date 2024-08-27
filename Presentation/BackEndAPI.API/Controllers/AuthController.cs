using BackEndAPI.Application.DTOs;
using BackEndAPI.Application.Features.UserFeatures.Command.UserRegister;
using MediatR;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace BackEndAPI.API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class AuthController : ControllerBase
    {
        private readonly IMediator mediator;

        public AuthController(IMediator mediator)
        {
            this.mediator = mediator;
        }
        [HttpPost("register")]
        public async Task<IActionResult> UserRegister(UserRegisterCommandRequest userRegisterCommandRequest)
        {
           UserRegisterCommandResponse response = await mediator.Send(userRegisterCommandRequest);
            return Ok(response);
        }
    }
}
