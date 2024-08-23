using BackEndAPI.Application.Repositories.User;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BackEndAPI.Persistence.Repositories.User
{
    public class UserReadRepository : ReadRepository<Domain.Entities.User>, IUserReadRepository
    {
        public UserReadRepository(AppDbContext.AppDbContext dbContext) : base(dbContext)
        {
        }
    }
}
