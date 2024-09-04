using BackEndAPI.Application.DTOs;
using BackEndAPI.Application.Services;
using BackEndAPI.Domain.Entities;
using Microsoft.AspNetCore.Http;
using Microsoft.Extensions.Configuration;
using Microsoft.IdentityModel.Tokens;
using System.IdentityModel.Tokens.Jwt;
using System.Reflection.Metadata.Ecma335;
using System.Security.Claims;
using System.Text;

namespace BackEndAPI.Infrastructure.Services
{
    public class TokenService : ITokenService

    {
        private readonly IConfiguration configuration;
        private readonly IHttpContextAccessor httpContextAccessor;

        public TokenService(IConfiguration configuration, IHttpContextAccessor httpContextAccessor)
        {
            this.configuration = configuration;
            this.httpContextAccessor = httpContextAccessor;
        }

        public Token CreateToken(User user)
        {
            Token token = new Token();
            SymmetricSecurityKey securityKey = new(Encoding.UTF8.GetBytes(configuration["Token:SecretKey"]));
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
                claims: new List<Claim>
                {
                    new(ClaimTypes.Name, user.UserName),
                }

                );

            JwtSecurityTokenHandler tokenHandler = new();
            token.AccessToken = tokenHandler.WriteToken(securityToken);
            return token;
        }
        public ClaimsPrincipal? ValidateToken(string token)
        {
            JwtSecurityTokenHandler tokenHandler = new();
            var securityKey = Encoding.UTF8.GetBytes(configuration["Token:SecretKey"]);

            var validationParameters = new TokenValidationParameters
            {
                ValidateIssuer = true,
                ValidateAudience = true,
                ValidateLifetime = true,
                ValidateIssuerSigningKey = true,
                ValidIssuer = configuration["Token:Issuer"],
                ValidAudience = configuration["Token:Audience"],
                IssuerSigningKey = new SymmetricSecurityKey(securityKey)
            };
            try
            {
                var principal = tokenHandler.ValidateToken(token, validationParameters, out SecurityToken validatedToken);

                return principal;
            }
            catch
            {

                return null;
            }
        }
        public string GetUsernameFromToken(string token)
        {
            var principal = ValidateToken(token);
            if (principal is null) return  null;
               

            var usernameClaim = principal.Claims.FirstOrDefault(c => c.Type == ClaimTypes.Name);
            return usernameClaim?.Value;
        }

        public string GetTokenFromHeader()
        {
            var token = httpContextAccessor.HttpContext.Request.Headers.Authorization.FirstOrDefault().Replace("Bearer ", string.Empty);

            Console.WriteLine(token);
            return token;
        }
    }
}
