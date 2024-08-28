using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BackEndAPI.Application.Exceptions
{
    public class UserLoginFailedException : Exception
    {
        public UserLoginFailedException(string? message) : base(message)
        {
        }
    }
}
