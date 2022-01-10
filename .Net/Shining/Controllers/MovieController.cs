using DTOs.Movie;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Services.Abstractions;
using Services.QueryStringParameters;
using System.Linq;
using System.Text.Json;
using System.Threading;
using System.Threading.Tasks;

namespace Shining.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class MovieController : ControllerBase
    {
        private readonly IServiceManager _serviceManager;

        public MovieController(IServiceManager serviceManager) => _serviceManager = serviceManager;

        [AllowAnonymous]
        [HttpGet]
        public async Task<IActionResult> GetAllMovies([FromQuery] MovieParameters parameters)
        {
            var movies =  await _serviceManager.MovieService.GetAll(parameters);

            var metadata = new
            {
                movies.TotalCount, movies.PageSize, movies.CurrentPage, movies.TotalPages, movies.HasNext, movies.HasPrevious, parameters.Order 
            };

            Response.Headers.Add("X-Pagination", JsonSerializer.Serialize(metadata));

            //Thread.Sleep(2000);

            return Ok(movies);
        }


        [HttpGet("{movieId}")]
        public async Task<IActionResult> GetMovieById(int movieId)
        {
            var movieDTO = await _serviceManager.MovieService.GetById(movieId);

            return Ok(movieDTO);
        }


        [Authorize(Roles = "Administrator")]
        [HttpPost]
        public async Task<IActionResult> CreateMovie([FromBody] MovieForCreationDTO movieForCreationDTO)
        {
            var movieDTO = await _serviceManager.MovieService.Create(movieForCreationDTO);


            return CreatedAtAction(nameof(CreateMovie), movieDTO);
        }
        

        [Authorize(Roles = "Administrator")]
        [HttpPut("{movieId}")]
        public async Task<IActionResult> UpdateMovie(int movieId, [FromBody] MovieForUpdateDTO movieForUpdateDTO)
        {
            await _serviceManager.MovieService.Update(movieId, movieForUpdateDTO);

            return NoContent();
        }

        [Authorize(Roles = "Administrator")]
        [HttpDelete("{movieId}")]
        public async Task<IActionResult> DeleteMovie(int movieId)
        {
            await _serviceManager.MovieService.Delete(movieId);

            return NoContent();
        }
    }
}
