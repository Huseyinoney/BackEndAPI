using BackEndAPI.Application.DTOs;
using BackEndAPI.Application.Services;
using BackEndAPI.Domain.Entities;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace BackEndAPI.API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class EntityController : ControllerBase
    {
        private readonly IEntityService entityService;

        public EntityController(IEntityService entityService)
        {
            this.entityService = entityService;
        }

        [HttpPost]
        public async Task<IActionResult> GetEntity(GetEntityDTO getEntityDTO) 
        {
        Entity response = await entityService.GetEntityAsync(getEntityDTO);
            return Ok(response);
        }

    }

}
