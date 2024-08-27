using AutoMapper;
using BackEndAPI.Application.Exceptions;
using BackEndAPI.Application.UnitOfWorks;
using BackEndAPI.Domain.Entities;
using MediatR;
using Microsoft.AspNetCore.Identity;
using System;
using System.Collections.Generic;
using System.ComponentModel.Design;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BackEndAPI.Application.Features.UserFeatures.Command.UserRegister
{
    public class UserRegisterCommandHandler : IRequestHandler<UserRegisterCommandRequest, UserRegisterCommandResponse>

    {
        private readonly UserManager<User> _userManager;
        private readonly IUnitOfWork unitOfWork;
        private IMapper Mapper;

        public UserRegisterCommandHandler(IUnitOfWork unitOfWork, IMapper mapper, UserManager<User> userManager)
        {
            this.unitOfWork = unitOfWork;
            Mapper = mapper;
            _userManager = userManager;
        }

        public async Task<UserRegisterCommandResponse> Handle(UserRegisterCommandRequest request, CancellationToken cancellationToken)
        {
            User mappedUser = Mapper.Map<User>(request);
            
            IdentityResult result = await _userManager.CreateAsync(mappedUser);
            if (result.Succeeded)
            {
                return new()
                {
                   
                    Succeeded = true,
                    Message = "Kullanıcı Oluşturuldu."
                };
            }
            throw new UserCreateFailedException("Bir hata ile karşılaşıldı.");
        }
    }
}
