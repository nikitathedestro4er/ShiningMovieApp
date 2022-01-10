using DTOs.Actor;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Services.Abstractions;
using Services.QueryStringParameters;
using System.Text.Json;
using System.Threading.Tasks;

namespace Shining.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class ActorController : ControllerBase
    {
        private readonly IServiceManager _serviceManager;

        public ActorController(IServiceManager serviceManager) => _serviceManager = serviceManager;


        [HttpGet]
        public async Task<IActionResult> GetAllActors([FromQuery] ActorParameters parameters)
        {
            var actors = await _serviceManager.ActorService.GetAll(parameters);

            var metadata = new
            {
                actors.TotalCount,
                actors.PageSize,
                actors.CurrentPage,
                actors.TotalPages,
                actors.HasNext,
                actors.HasPrevious,
                parameters.Order
            };

            Response.Headers.Add("X-Pagination", JsonSerializer.Serialize(metadata));

            return Ok(actors);
        }
        

        [HttpGet("{actorId}")]
        public async Task<IActionResult> GetActorById(int actorId)
        {
            var actorDTO = await _serviceManager.ActorService.GetById(actorId);

            return Ok(actorDTO);
        }


        [Authorize(Roles = "Administrator")]
        [HttpPost]
        public async Task<IActionResult> CreateActor([FromBody] ActorForCreationDTO actorForCreationDTO)
        {
            var actorDTO = await _serviceManager.ActorService.Create(actorForCreationDTO);


            return CreatedAtAction(nameof(CreateActor), actorDTO);
        }


        [Authorize(Roles = "Administrator")]
        [HttpPut("{actorId}")]
        public async Task<IActionResult> UpdateActor(int actorId, [FromBody] ActorForUpdateDTO actorForUpdateDTO)
        {
            await _serviceManager.ActorService.Update(actorId, actorForUpdateDTO);

            return NoContent();
        }

        [Authorize(Roles = "Administrator")]
        [HttpDelete("{actorId}")]
        public async Task<IActionResult> DeleteActor(int actorId)
        {
            await _serviceManager.ActorService.Delete(actorId);

            return NoContent();
        }

    }
}
