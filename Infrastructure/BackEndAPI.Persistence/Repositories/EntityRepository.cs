using BackEndAPI.Application.DTOs;
using BackEndAPI.Application.Repositories;
using BackEndAPI.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BackEndAPI.Persistence.Repositories
{
    public class EntityRepository : IEntityRepository
    {
        public Entity GetEntity(GetEntityDTO getEntityDTO)
        {
            throw new NotImplementedException();
        }
    }

}
