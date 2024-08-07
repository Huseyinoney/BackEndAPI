using AutoMapper;
using BackEndAPI.Application.DTOs;
using BackEndAPI.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BackEndAPI.Application.Mapping
{
    public class EntityMapper : Profile
    {
        public EntityMapper() 
        {
            CreateMap<Entity, GetEntityResponseDTO>();
            CreateMap<GetEntityResponseDTO, Entity>();
            CreateMap<GetEntityDTO,Entity>();
            CreateMap<Entity,GetEntityDTO>();

        }
    }
}
