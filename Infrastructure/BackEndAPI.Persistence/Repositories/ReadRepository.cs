using BackEndAPI.Application.Repositories;
using Microsoft.EntityFrameworkCore;
using System.Linq.Expressions;

namespace BackEndAPI.Persistence.Repositories
{
    public class ReadRepository<T> : IReadRepository<T> where T : class, new()
    {
        private readonly AppDbContext.AppDbContext _dbContext;

        public ReadRepository(AppDbContext.AppDbContext dbContext)
        {
            _dbContext = dbContext;
        }
        private DbSet<T> Table { get => _dbContext.Set<T>(); }

        public async Task<T> GetAsync(Expression<Func<T, bool>> predicate)
        {
            return  await Table.FirstOrDefaultAsync(predicate);
        }
    }
}
