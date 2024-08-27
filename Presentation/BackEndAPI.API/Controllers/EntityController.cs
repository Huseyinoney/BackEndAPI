using BackEndAPI.Application.DTOs;
using BackEndAPI.Application.Features.EntityFeatures.Query.GetEntity;
using BackEndAPI.Domain.Entities;
using MediatR;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;

namespace BackEndAPI.API.Controllers
{
    //[Authorize]
    [Route("api/[controller]")]
    [ApiController]
    public class EntityController : ControllerBase
    {
        private readonly IMediator mediator;

        public EntityController(IMediator mediator)
        {
            this.mediator = mediator;
        }
        [HttpPost]
        public async Task<IActionResult> GetEntity(GetEntityQueryRequest GetEntityQueryRequest)
        {
          var response =  await mediator.Send(GetEntityQueryRequest);

            if (response == null)
            {
                return StatusCode(StatusCodes.Status404NotFound);
            }

            return Ok(response);
        }

    }

}
