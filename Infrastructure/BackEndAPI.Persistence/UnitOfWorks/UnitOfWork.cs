using BackEndAPI.Application.Repositories;
using BackEndAPI.Application.UnitOfWorks;
using BackEndAPI.Persistence.AppDbContext;
using BackEndAPI.Persistence.Repositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BackEndAPI.Persistence.UnitOfWorks
{
    public class UnitOfWork : IUnitOfWork
    {
        private readonly AppDbContext.AppDbContext _dbContext;
        public UnitOfWork(AppDbContext.AppDbContext dbContext)
        {
            _dbContext = dbContext;
        }

        async ValueTask IAsyncDisposable.DisposeAsync() => await _dbContext.DisposeAsync();

        IReadRepository<T> IUnitOfWork.GetReadRepository<T>() => new ReadRepository<T>(_dbContext);

        IWriteRepository<T> IUnitOfWork.GetWriteRepository<T>() => new WriteRepository<T>(_dbContext);

        async Task IUnitOfWork.SaveAsync() => await _dbContext.SaveChangesAsync();
        
    }
}
