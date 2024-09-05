using BackEndAPI.Application.Features.UserFeatures.Command.UserChangePassword;
using BackEndAPI.Application.Features.UserFeatures.Command.UserLogin;
using BackEndAPI.Application.Features.UserFeatures.Command.UserRegister;
using MediatR;
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

        [HttpPost("login")]

        public async Task<IActionResult> Login(UserLoginCommandRequest userLoginCommandRequest)
        {
          UserLoginCommandResponse response = await mediator.Send(userLoginCommandRequest);
            return Ok(response);
        }

        
        [HttpPost("ChangePassword")]
        public async Task<IActionResult> ChangePassword(UserChangePasswordCommandRequest userChangePasswordCommandRequest) 
        {
           UserChangePasswordCommandResponse response = await mediator.Send(userChangePasswordCommandRequest);
            return Ok(response);
        }

    }
}
