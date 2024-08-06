using BackEndAPI.Application.DTOs;
using BackEndAPI.Application.Repositories;
using BackEndAPI.Domain.Entities;
using BackEndAPI.Persistence.AppDbContext;


namespace BackEndAPI.Persistence.Repositories
{
    public class EntityRepository : IEntityRepository
    {
        private readonly EntityDbContext _dbContext;

        public EntityRepository(EntityDbContext dbContext)
        {
            _dbContext = dbContext;
        }

        public async Task<GetEntityResponseDTO> GetEntityAsync(GetEntityDTO getEntityDTO)
        {
            //mapper işlemi yapılacak getEntityDTO ->Entity (mapper kütüphanesi ile) 
            Entity entity = new Entity
            {
                Name = getEntityDTO.Name
            };
                return await _dbContext.Entities.FindAsync(entity);
        }
    }
}
