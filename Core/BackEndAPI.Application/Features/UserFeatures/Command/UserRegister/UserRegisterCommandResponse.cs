using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BackEndAPI.Application.Features.UserFeatures.Command.UserRegister
{
    public class UserRegisterCommandResponse
    {
       
        public bool Succeeded { get;  set; }
        public string Message { get;  set; }
    }
}
