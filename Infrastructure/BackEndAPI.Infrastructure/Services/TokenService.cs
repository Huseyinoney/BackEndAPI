using BackEndAPI.Application.DTOs;
using BackEndAPI.Application.Services;
using BackEndAPI.Domain.Entities;
using Microsoft.Extensions.Configuration;
using Microsoft.IdentityModel.Tokens;
using System;
using System.Collections.Generic;
using System.IdentityModel.Tokens.Jwt;
using System.Linq;
using System.Security.Claims;
using System.Text;
using System.Threading.Tasks;

namespace BackEndAPI.Infrastructure.Services
{
    public class TokenService : ITokenService
        
    {
      private readonly IConfiguration configuration;

        public TokenService(IConfiguration configuration)
        {
            this.configuration = configuration;
        }

        public Token CreateToken(User user)
        {
           Token token = new Token();
            SymmetricSecurityKey securityKey = new(Encoding.UTF8.GetBytes(configuration["Token:SecurityKey"]));
            SigningCredentials signingCredentials = new(securityKey, SecurityAlgorithms.HmacSha256);

            token.Expiration = DateTime.UtcNow.AddMinutes(30);
            var clms = new ClaimsIdentity();
            clms.AddClaim(new Claim(ClaimTypes.Name, user.UserName));
           
            JwtSecurityToken securityToken = new(
                audience: configuration["Token:Audience"],
                issuer: configuration["Token:Issuer"],
                expires: token.Expiration,
                notBefore: DateTime.UtcNow,
                signingCredentials: signingCredentials,
                claims : new List<Claim>
                {
                    new(ClaimTypes.Name, user.UserName),
                }
               
                );

            JwtSecurityTokenHandler tokenHandler = new();
            token.AccessToken = tokenHandler.WriteToken(securityToken);
            return token;

        }
    }
}
