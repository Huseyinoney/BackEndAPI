using BackEndAPI.Application.DTOs;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BackEndAPI.Application.Services
{
    public interface IUserService
    {
        public void AddUser(UserRegisterDTO userRegisterDTO);
    }
}
