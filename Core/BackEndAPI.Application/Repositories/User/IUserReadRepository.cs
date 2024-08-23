using BackEndAPI.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BackEndAPI.Application.Repositories.User
{
    public interface IUserReadRepository :IReadRepository<Domain.Entities.User>
    {
    }
}
