using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Domain.Entities;
using Domain.Exceptions;
using Domain.Services.Repositories;
using DTOs.Comment;
using Mapster;
using Services.Abstractions;

namespace Services.Services
{
    internal sealed class CommentService : ICommentService
    {
        
        private const string ImagesFolderName = "Images";

        private readonly IUnitOfWork _unitOfWork;

        private readonly IFileService _fileService;

        public CommentService(IUnitOfWork unitOfWork, IFileService fileService)
        {
            _unitOfWork = unitOfWork;
            _fileService = fileService;
        }
        
        public async Task<List<CommentDTO>> GetAllByMovieId(int movieId)
        {
            var allComments = await _unitOfWork.CommentRepository.GetAll();

            var movieComments = allComments.Where(x => x.MovieId == movieId).OrderBy(x=>x.CreationTime);

            foreach (var comment in movieComments)
            {
                comment.Replies = comment.Replies.OrderByDescending(x => x.CreationTime).ToList();
            }
            
             var movieCommentsDto = movieComments.Adapt<List<CommentDTO>>();

             foreach (var comment in movieCommentsDto)
             {
                 var customer = await  _unitOfWork.CustomerRepository.GetById(comment.CustomerId);

                 comment.Image = _fileService.GetFilePath($"{ImagesFolderName}/{customer.Image}");
             }

             return movieCommentsDto;
        }

        public async Task<CommentDTO> GetById(int commentId)
        {
            var comment = await _unitOfWork.CommentRepository.GetById(commentId);

            if (comment is null)
            {
                throw new CommentNotFoundException(commentId);
            }
            
            return comment.Adapt<CommentDTO>();
        }

        public async Task<CommentDTO> Create(CommentForCreationDTO commentForCreation)
        {
            var comment = commentForCreation.Adapt<Comment>();
            
            _unitOfWork.CommentRepository.Insert(comment);

            await _unitOfWork.Commit();

            var commentFromDb = await _unitOfWork.CommentRepository.GetById(comment.Id);

            commentFromDb.Replies = new List<ReplyComment>();

            var commentFromDbDto = commentFromDb.Adapt<CommentDTO>();
            
            var customer = await  _unitOfWork.CustomerRepository.GetById(commentFromDbDto.CustomerId);
            
            commentFromDbDto.Image = _fileService.GetFilePath($"{ImagesFolderName}/{customer.Image}");

            return commentFromDbDto;
        }

        public async Task Update(int commentId, CommentDTO commentForUpdateDto)
        {
            var comment = await _unitOfWork.CommentRepository.GetById(commentId);
            
            if (comment is null)
            {
                throw new CommentNotFoundException(commentId);
            }

            var commentForUpdate = commentForUpdateDto.Adapt<Comment>();
            
            comment.Content = commentForUpdate.Content;
            
            comment.Likes = commentForUpdate.Likes;
            
            comment.Dislikes = commentForUpdate.Dislikes;
            
            if (comment.Replies.Count == commentForUpdate.Replies.Count)
            {
                comment.ModifiedDate = DateTime.Now;
            }

            UpdateReplies(comment, commentForUpdate);
            
            await _unitOfWork.Commit();
        }

        
        public async Task Delete(int commentId)
        {
            var comment = await _unitOfWork.CommentRepository.GetById(commentId);
            
            if (comment is null)
            {
                throw new CommentNotFoundException(commentId);
            }
            
            _unitOfWork.CommentRepository.Remove(comment);

            await _unitOfWork.Commit();
        }


        private static void UpdateReplies(Comment comment, Comment commentForUpdate)
        {
            if (comment.Replies.Count == commentForUpdate.Replies.Count)
            {
                return;
            }
            
            comment.Replies.Clear();

            foreach (var reply in commentForUpdate.Replies)
            {
                comment.Replies.Add(reply);
            }
        }
    }
}