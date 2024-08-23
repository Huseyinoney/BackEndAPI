using BackEndAPI.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BackEndAPI.Application.Repositories.Entity
{
    public interface IEntityReadRepository : IReadRepository<Domain.Entities.Entity>
    {
    }
}
