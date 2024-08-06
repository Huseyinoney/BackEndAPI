using BackEndAPI.Application.DTOs;
using BackEndAPI.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BackEndAPI.Application.Repositories
{
    public interface IEntityRepository
    {
        public  Task<GetEntityResponseDTO> GetEntityAsync(GetEntityDTO getEntityDTO);
    }
}
