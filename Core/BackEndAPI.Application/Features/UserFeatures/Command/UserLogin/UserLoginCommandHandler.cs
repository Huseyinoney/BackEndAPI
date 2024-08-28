using AutoMapper;
using BackEndAPI.Application.DTOs;
using BackEndAPI.Application.Exceptions;
using BackEndAPI.Application.Services;
using BackEndAPI.Domain.Entities;
using MediatR;
using Microsoft.AspNetCore.Identity;

namespace BackEndAPI.Application.Features.UserFeatures.Command.UserLogin
{
    public class UserLoginCommandHandler : IRequestHandler<UserLoginCommandRequest, UserLoginCommandResponse>
    {
        private readonly UserManager<User> userManager;
        private readonly ITokenService tokenService;
        private readonly IMapper mapper;

        public UserLoginCommandHandler(UserManager<User> userManager, ITokenService tokenService, IMapper mapper)
        {
            this.userManager = userManager;
            this.tokenService = tokenService;
            this.mapper = mapper;
        }
        public async Task<UserLoginCommandResponse> Handle(UserLoginCommandRequest request, CancellationToken cancellationToken)
        {
            User user = await userManager.FindByEmailAsync(request.Email);

            if (user is not null)
            {
                bool checkPassword = await userManager.CheckPasswordAsync(user, request.Password);
                if (checkPassword)
                {
                    Token token = tokenService.CreateToken(user);
                    var mapping = mapper.Map<UserLoginCommandResponse>(token);
                    return mapping;
                }
                throw new UserLoginFailedException("Email Veya Şifre Hatalı");
            }
            throw new UserLoginFailedException("Email veya Şifre Hatalı");
        }
    }
}
