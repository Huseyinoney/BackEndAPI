using Azure;
using BackEndAPI.Application.DTOs;
using BackEndAPI.Application.Repositories;
using BackEndAPI.Domain.Entities;
using BackEndAPI.Persistence.AppDbContext;
using Microsoft.AspNetCore.Http.HttpResults;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

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
