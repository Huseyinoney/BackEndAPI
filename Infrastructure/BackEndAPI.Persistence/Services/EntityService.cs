using AutoMapper;
using BackEndAPI.Application.DTOs;
using BackEndAPI.Application.Repositories;
using BackEndAPI.Application.Services;
using BackEndAPI.Domain.Entities;

namespace BackEndAPI.Persistence.Services
{
    public class EntityService : IEntityService
    {
        private readonly IEntityRepository _entityRepository;
        private readonly IMapper _mapper;

        public EntityService(IEntityRepository entityRepository, IMapper mapper)
        {
            _entityRepository = entityRepository;
            _mapper = mapper;
        }
        public async Task<GetEntityResponseDTO> GetEntityAsync(GetEntityDTO getEntityDTO)
        {
            Entity response = await _entityRepository.GetEntityAsync(getEntityDTO);
            GetEntityResponseDTO data = _mapper.Map<GetEntityResponseDTO>(response);
            return data;
        }
    }
}
