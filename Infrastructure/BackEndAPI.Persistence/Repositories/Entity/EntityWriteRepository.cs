using BackEndAPI.Application.Repositories;
using BackEndAPI.Application.Repositories.Entity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BackEndAPI.Persistence.Repositories.Entity
{
    public class EntityWriteRepository : WriteRepository<Domain.Entities.Entity>, IEntityWriteRepository
    {
        public EntityWriteRepository(AppDbContext.AppDbContext appDbContext) : base(appDbContext)
        {
        }
    }
}
