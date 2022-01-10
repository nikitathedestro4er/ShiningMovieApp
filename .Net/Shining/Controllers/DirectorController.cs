using DTOs.Director;
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
    public class DirectorController : ControllerBase
    {
        private readonly IServiceManager _serviceManager;

        public DirectorController(IServiceManager serviceManager) => _serviceManager = serviceManager;


        [HttpGet]
        public async Task<IActionResult> GetAllDirectors([FromQuery] DirectorParameters parameters)
        {
            var directors = await _serviceManager.DirectorService.GetAll(parameters);

            var metadata = new
            {
                directors.TotalCount,
                directors.PageSize,
                directors.CurrentPage,
                directors.TotalPages,
                directors.HasNext,
                directors.HasPrevious,
                parameters.Order
            };

            Response.Headers.Add("X-Pagination", JsonSerializer.Serialize(metadata));

            return Ok(directors);
        }


        [HttpGet("{directorId}")]
        public async Task<IActionResult> GetDirectorById(int directorId)
        {
            var directorDTO = await _serviceManager.DirectorService.GetById(directorId);

            return Ok(directorDTO);
        }


        [Authorize(Roles = "Administrator")]
        [HttpPost]
        public async Task<IActionResult> CreateDirector([FromBody] DirectorForCreationDTO directorForCreationDTO)
        {
            var directorDTO = await _serviceManager.DirectorService.Create(directorForCreationDTO);


            return CreatedAtAction(nameof(CreateDirector), directorDTO);
        }


        [Authorize(Roles = "Administrator")]
        [HttpPut("{directorId}")]
        public async Task<IActionResult> UpdateDirector(int directorId, [FromBody] DirectorForUpdateDTO directorForUpdateDTO)
        {
            await _serviceManager.DirectorService.Update(directorId, directorForUpdateDTO);

            return NoContent();
        }

        [Authorize(Roles = "Administrator")]
        [HttpDelete("{directorId}")]
        public async Task<IActionResult> DeleteDirector(int directorId)
        {
            await _serviceManager.DirectorService.Delete(directorId);

            return NoContent();
        }
    }
}
