using BackEndAPI.Application.DTOs;
using BackEndAPI.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace BackEndAPI.Application.Repositories
{
    public interface IReadRepository<T> where T : class, new()
    {
        public Task<T> GetAsync(Expression<Func<T,bool>> predicate);
    }
}
