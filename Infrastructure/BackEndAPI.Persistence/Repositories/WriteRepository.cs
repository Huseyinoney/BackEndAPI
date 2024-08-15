using BackEndAPI.Application.Repositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BackEndAPI.Persistence.Repositories
{
    public class WriteRepository<T> : IWriteRepository<T> where T : class, new()
    {
        private readonly AppDbContext.AppDbContext _appDbContext;

        public WriteRepository(AppDbContext.AppDbContext appDbContext)
        {
            _appDbContext = appDbContext;
        }

    }
}
