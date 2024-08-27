using AutoMapper;
using BackEndAPI.Application.DTOs;
using BackEndAPI.Application.Features.UserFeatures.Command.UserRegister;
using BackEndAPI.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BackEndAPI.Application.Mapping
{
    public class UserMapper : Profile
    {
        public UserMapper()
        {
            CreateMap<UserRegisterCommandRequest, User>()
                .ForMember(dest => dest.UserName, opt => opt.MapFrom(src => src.UserName))
            .ForMember(dest => dest.Email, opt => opt.MapFrom(src => src.Email))
            .ForMember(dest => dest.PasswordHash, opt => opt.MapFrom(src => src.Password));
           
            CreateMap<User, UserRegisterCommandRequest>();
        }
    }
}
