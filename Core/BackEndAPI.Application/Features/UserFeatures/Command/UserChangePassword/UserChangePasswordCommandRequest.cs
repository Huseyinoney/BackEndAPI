using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BackEndAPI.Application.Features.UserFeatures.Command.UserChangePassword
{
    public class UserChangePasswordCommandRequest: IRequest<UserChangePasswordCommandResponse>
    {
        public string OldPassword { get; set; }
        public string NewPassword { get; set; }
        public string NewPasswordConfirm{ get; set; }
    }
}
