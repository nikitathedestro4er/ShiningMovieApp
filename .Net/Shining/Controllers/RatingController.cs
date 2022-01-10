using System.Threading.Tasks;
using DTOs.Comment;
using DTOs.Rating;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Services.Abstractions;

namespace Shining.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class RatingController : ControllerBase
    {
        
        private readonly IServiceManager _serviceManager;
        
        
        public RatingController(IServiceManager serviceManager)
        {
            _serviceManager = serviceManager;
        }
        
        
        [Authorize(Roles = "User,Administrator")]
        [HttpPost]
        public async Task<IActionResult> RateMovie([FromBody] RatingDTO ratingDto)
        {
            await _serviceManager.RatingService.Create(ratingDto);

            return Ok();
        }
    }
}