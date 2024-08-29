using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BackEndAPI.Application.Exceptions
{
    public class UserChangePasswordFailedException : Exception
    {
        public UserChangePasswordFailedException(string? message) : base(message)
        {
        }
    }
}
