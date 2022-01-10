using System.Collections.Generic;
using System.Threading.Tasks;
using DTOs.Actor;
using DTOs.Comment;

namespace Services.Abstractions
{
    public interface ICommentService
    {
        Task<List<CommentDTO>> GetAllByMovieId(int movieId);

        Task<CommentDTO> GetById(int commentId);

        Task<CommentDTO> Create(CommentForCreationDTO commentForCreation);

        Task Update(int commentId, CommentDTO comment);

        Task Delete(int commentId);
    }
}