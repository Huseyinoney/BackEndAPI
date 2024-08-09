using BackEndAPI.Application.DTOs;
using BackEndAPI.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection.Metadata;
using System.Text;
using System.Threading.Tasks;

namespace BackEndAPI.Application.Services
{
    public interface ITokenService
    {
        public Token CreateToken(User user);
    }
}
