using AutoMapper;
using BackEndAPI.Application.DTOs;
using BackEndAPI.Application.Features.EntityFeatures.Query.GetEntity;
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
            CreateMap<GetEntityQueryResponse,Entity>();
            CreateMap<Entity, GetEntityQueryResponse>()
                .ForMember(destination => destination.Name, operation => operation.MapFrom(source => source.Name));

        }
    }
}
