using AutoMapper;
using BackEndAPI.Application.Exceptions;
using BackEndAPI.Application.Services;
using BackEndAPI.Domain.Entities;
using MediatR;
using Microsoft.AspNetCore.Identity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BackEndAPI.Application.Features.UserFeatures.Command.UserChangePassword
{
    public class UserChangePasswordCommandHandler : IRequestHandler<UserChangePasswordCommandRequest, UserChangePasswordCommandResponse>
    {
        private readonly UserManager<User> userManager;
        private readonly IMapper mapper;
        private readonly ITokenService tokenService;

        public UserChangePasswordCommandHandler(IMapper mapper, UserManager<User> userManager, ITokenService tokenService)
        {
            this.mapper = mapper;
            this.userManager = userManager;
            this.tokenService = tokenService;
        }

        public async Task<UserChangePasswordCommandResponse> Handle(UserChangePasswordCommandRequest request, CancellationToken cancellationToken)
        {
            string token = tokenService.GetTokenFromHeader();
            if (token is null)
            {
                throw new UserChangePasswordFailedException("Token Bulunamadı");
            }
            string UserName = tokenService.GetUsernameFromToken(token);

            User user = await userManager.FindByNameAsync(UserName);
            if (user is null)
            {
                throw new UserChangePasswordFailedException("Kullanıcı Bulunamadı");
            }

            bool isOldPasswordSame = await userManager.CheckPasswordAsync(user, request.OldPassword);

            if (isOldPasswordSame)
            {
                var result = await userManager.ChangePasswordAsync(user, request.OldPassword, request.NewPassword);
                if (result.Succeeded)
                {
                    return new()
                    {
                        Message = result.ToString()
                    };

                }
                throw new UserChangePasswordFailedException("Bir hata oluştu");
            }
            throw new UserChangePasswordFailedException("Eski şifre Doğru Değil");

        }
    }
}
