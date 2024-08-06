using BackEndAPI.Application.DTOs;
using BackEndAPI.Application.Repositories;
using BackEndAPI.Application.Services;
using BackEndAPI.Domain.Entities;

namespace BackEndAPI.Persistence.Services
{
    public class EntityService : IEntityService
    {
        private readonly IEntityRepository _entityRepository;

        public EntityService(IEntityRepository entityRepository)
        {
            _entityRepository = entityRepository;
        }
        public async Task<GetEntityResponseDTO> GetEntityAsync(GetEntityDTO getEntityDTO)
        {
            return await _entityRepository.GetEntityAsync(getEntityDTO);
        }
    }
}
