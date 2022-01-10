using Microsoft.AspNetCore.Mvc;
using Services.Abstractions;
using System.Threading.Tasks;

namespace Shining.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class GenreController : ControllerBase
    {
        private readonly IServiceManager _serviceManager;

        public GenreController(IServiceManager serviceManager) => _serviceManager = serviceManager;
        

        [HttpGet]
        public async Task<IActionResult> GetAllGenres()
        {
            var genres = await _serviceManager.GenreService.GetAll();

            return Ok(genres);
        }


        [HttpGet("{genreId}")]
        public async Task<IActionResult> GetGenreById(int genreId)
        {
            var genreDTO = await _serviceManager.GenreService.GetById(genreId);

            return Ok(genreDTO);
        }
    }
}
