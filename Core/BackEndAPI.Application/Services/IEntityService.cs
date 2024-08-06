using BackEndAPI.Application.DTOs;
using BackEndAPI.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BackEndAPI.Application.Services
{
    public interface IEntityService
    {
        public  Task<Entity> GetEntityAsync(GetEntityDTO getEntityDTO);
    }
}
