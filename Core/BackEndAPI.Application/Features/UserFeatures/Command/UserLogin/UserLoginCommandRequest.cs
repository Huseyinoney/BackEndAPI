using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BackEndAPI.Application.Features.UserFeatures.Command.UserLogin
{
    public class UserLoginCommandRequest :IRequest<UserLoginCommandResponse>
    {
        public string Email { get; set; }
        public string Password { get; set; }
    }
}
