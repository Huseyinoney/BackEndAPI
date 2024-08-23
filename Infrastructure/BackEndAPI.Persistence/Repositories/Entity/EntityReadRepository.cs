using BackEndAPI.Application.Repositories.Entity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BackEndAPI.Persistence.Repositories.Entity
{
    public class EntityReadRepository : ReadRepository<Domain.Entities.Entity>, IEntityReadRepository
    {
        public EntityReadRepository(AppDbContext.AppDbContext dbContext) : base(dbContext)
        {
        }
    }
}
