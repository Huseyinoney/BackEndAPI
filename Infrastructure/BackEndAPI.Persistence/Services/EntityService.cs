using AutoMapper;
using BackEndAPI.Application.DTOs;
using BackEndAPI.Application.Repositories;
using BackEndAPI.Application.Services;
using BackEndAPI.Application.UnitOfWorks;
using BackEndAPI.Domain.Entities;
using BackEndAPI.Persistence.Repositories;
using Microsoft.EntityFrameworkCore;

namespace BackEndAPI.Persistence.Services
{
    public class EntityService : IEntityService
    {
        private IUnitOfWork unitOfWork;
        private readonly IMapper _mapper;

        public EntityService( IMapper mapper, IUnitOfWork unitOfWork)
        {
            _mapper = mapper;
            this.unitOfWork = unitOfWork;
        }
        public async Task<GetEntityResponseDTO> GetEntityAsync(GetEntityDTO getEntityDTO)
        {
            Entity response = await unitOfWork.GetReadRepository<Entity>().GetAsync(x => x.Name == getEntityDTO.Name).FirstOrDefaultAsync();
            if (response == null)
            {
                return null;
            }
            GetEntityResponseDTO data = _mapper.Map<GetEntityResponseDTO>(response);
            return data;
        }
    }
}
