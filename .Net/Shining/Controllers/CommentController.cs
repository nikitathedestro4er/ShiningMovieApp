using System;
using System.Threading.Tasks;
using DTOs.Actor;
using DTOs.Comment;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Services.Abstractions;
using Shining.Services.GrpcAuthenticationService;

namespace Shining.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class CommentController : ControllerBase
    {
        private readonly IServiceManager _serviceManager;

        private readonly IRabbitMQService _rabbitService;

        public CommentController(IServiceManager serviceManager, IRabbitMQService rabbitService)
        {
            _serviceManager = serviceManager;

            _rabbitService = rabbitService;
        }
        
        
        [HttpGet("{movieId}")]
        public async Task<IActionResult> GetAllByMovieId(int movieId)
        {
            var comments = await _serviceManager.CommentService.GetAllByMovieId(movieId);

            
            //Thread.Sleep(2000);
            
            
            
            return Ok(comments);
            
           
        }
        
        

        [Authorize(Roles = "User,Administrator")]
        [HttpPost]
        public async Task<IActionResult> CreateComment([FromBody] CommentForCreationDTO commentForCreationDTO)
        {
            var commentDTO = await _serviceManager.CommentService.Create(commentForCreationDTO);
            

            return CreatedAtAction(nameof(CreateComment), commentDTO);
        }


        [Authorize(Roles = "User,Administrator")]
        [HttpPut("{commentId}")]
        public async Task<IActionResult> UpdateComment(int commentId, [FromBody] CommentDTO commentDTO)
        {
            await _serviceManager.CommentService.Update(commentId, commentDTO);

            return NoContent();
        }

        [Authorize(Roles = "User,Administrator")]
        [HttpDelete("{commentId}")]
        public async Task<IActionResult> DeleteComment(int commentId)
        {
            await _serviceManager.CommentService.Delete(commentId);

            return NoContent();
        }
    }
}