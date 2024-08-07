using AutoMapper;
using BackEndAPI.Application.DTOs;
using BackEndAPI.Application.Repositories;
using BackEndAPI.Domain.Entities;
using BackEndAPI.Persistence.AppDbContext;
using Microsoft.EntityFrameworkCore;


namespace BackEndAPI.Persistence.Repositories
{
    public class EntityRepository : IEntityRepository
    {
        private readonly EntityDbContext _dbContext;
        private readonly IMapper _mapper;

        public EntityRepository(EntityDbContext dbContext, IMapper mapper)
        {
            _dbContext = dbContext;
            _mapper = mapper;
        }

        public async Task<Entity> GetEntityAsync(GetEntityDTO getEntityDTO)
        {
            //mapper işlemi yapılacak getEntityDTO ->Entity (mapper kütüphanesi ile) 
            //Entity entity = _mapper.Map<Entity>(getEntityDTO);

           Entity response = await _dbContext.Entities.Where(e => e.Name.Equals(getEntityDTO.Name)).FirstOrDefaultAsync();
            return response;
        }
    }
}
