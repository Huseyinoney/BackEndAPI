using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BackEndAPI.Application.Repositories.Entity
{
    public interface IEntityWriteRepository :IWriteRepository<Domain.Entities.Entity>
    {
    }
}
