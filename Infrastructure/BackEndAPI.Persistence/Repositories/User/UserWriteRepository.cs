using BackEndAPI.Application.Repositories;
using BackEndAPI.Application.Repositories.User;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BackEndAPI.Persistence.Repositories.User
{
    public class UserWriteRepository : WriteRepository<Domain.Entities.User>, IUserWriteRepository
    {
        public UserWriteRepository(AppDbContext.AppDbContext appDbContext) : base(appDbContext)
        {
        }
    }
}
