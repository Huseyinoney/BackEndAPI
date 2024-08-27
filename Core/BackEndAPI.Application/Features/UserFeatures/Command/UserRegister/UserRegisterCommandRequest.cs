using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BackEndAPI.Application.Features.UserFeatures.Command.UserRegister
{
    public class UserRegisterCommandRequest :IRequest<UserRegisterCommandResponse>
    {
        public string UserName { get; set; }
        public string Password { get; set; }
        public string Email { get; set; }
    }
}
