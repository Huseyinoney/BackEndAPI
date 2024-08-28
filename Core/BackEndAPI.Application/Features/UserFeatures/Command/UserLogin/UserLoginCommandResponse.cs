using BackEndAPI.Application.DTOs;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BackEndAPI.Application.Features.UserFeatures.Command.UserLogin
{
    public class UserLoginCommandResponse
    {
        public Token Token { get; set; }
    }
}
