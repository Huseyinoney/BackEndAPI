using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BackEndAPI.Application.Repositories.User
{
    public interface IUserWriteRepository :IWriteRepository<Domain.Entities.User>
    {
    }
}
