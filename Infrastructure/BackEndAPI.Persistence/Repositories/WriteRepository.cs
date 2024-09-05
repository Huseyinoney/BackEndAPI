using BackEndAPI.Application.Repositories;

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
