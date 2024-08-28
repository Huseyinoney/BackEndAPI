using AutoMapper;
using BackEndAPI.Application.Exceptions;
using BackEndAPI.Application.UnitOfWorks;
using BackEndAPI.Domain.Entities;
using MediatR;
using Microsoft.AspNetCore.Identity;

namespace BackEndAPI.Application.Features.UserFeatures.Command.UserRegister
{
    public class UserRegisterCommandHandler : IRequestHandler<UserRegisterCommandRequest, UserRegisterCommandResponse>

    {
        private readonly UserManager<User> _userManager;
        private IMapper Mapper;

        public UserRegisterCommandHandler(IMapper mapper, UserManager<User> userManager)
        {

            Mapper = mapper;
            _userManager = userManager;
        }

        public async Task<UserRegisterCommandResponse> Handle(UserRegisterCommandRequest request, CancellationToken cancellationToken)
        {
            User user = await _userManager.FindByEmailAsync(request.Email);
            if (user != null)
            {
                throw new UserCreateFailedException("Böyle Bir E-Posta Daha Önce Kullanılmış");
            }
            user = await _userManager.FindByNameAsync(request.UserName);

            if (user != null)
            {
                throw new UserCreateFailedException("Bu Kullanıcı Adı Daha Önce Alınmış");
            }

            user = Mapper.Map<User>(request);
            var hashedPassword = _userManager.PasswordHasher.HashPassword(user, request.Password);
            user.PasswordHash = hashedPassword;

            IdentityResult result = await _userManager.CreateAsync(user);
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
