using BackEndAPI.Application.DTOs;
using BackEndAPI.Application.Services;
using BackEndAPI.Domain.Entities;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System.Reflection.Metadata.Ecma335;

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
            GetEntityResponseDTO response = await entityService.GetEntityAsync(getEntityDTO);
            if(response is not null)
            {
            Console.WriteLine(response);
            return Ok(response);

            }
            return StatusCode(400);
        }

    }

}
