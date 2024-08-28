using BackEndAPI.Application.DTOs;
using BackEndAPI.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Claims;
using System.Text;
using System.Threading.Tasks;

namespace BackEndAPI.Application.Services
{
    public interface ITokenService
    {
        public Token CreateToken(User user);
        public ClaimsPrincipal ValidateToken(string token);
        public string GetUsernameFromToken(string token);

        public string GetTokenFromHeader();
    }
}
