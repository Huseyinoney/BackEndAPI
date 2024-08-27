using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BackEndAPI.Application.Exceptions
{
    internal class UserCreateFailedException : Exception
    {
        public UserCreateFailedException(string? message) : base(message)
        {
        }
    }
}
