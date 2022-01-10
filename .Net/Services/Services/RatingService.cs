using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Domain.Entities;
using Domain.Services.Repositories;
using DTOs.Rating;
using Mapster;
using Services.Abstractions;

namespace Services.Services
{
    public class RatingService : IRatingService
    {
        private readonly IUnitOfWork _unitOfWork;
        
        public RatingService(IUnitOfWork unitOfWork)
        {
            _unitOfWork = unitOfWork;
        }

        public async Task<List<RatingDTO>> GetAllByMovie(int movieId)
        {
            var ratings = await _unitOfWork.RatingRepository.GetAllByMovie(movieId);

            var ratingsDto = ratings.Adapt<List<RatingDTO>>();

            return ratingsDto;
        }


        public async Task<RatingDTO> GetById(int ratingId)
        {
            var rating = await _unitOfWork.RatingRepository.GetById(ratingId);

            return rating.Adapt<RatingDTO>();
        }
        
        
        public async Task Create(RatingDTO ratingDto)
        {

            var ratings = await _unitOfWork.RatingRepository.GetAllByMovie(ratingDto.MovieId);

            var oldRating = ratings.FirstOrDefault(x => x.CustomerId == ratingDto.CustomerId);
            
            if (oldRating != null)
            {
                oldRating.Rate = ratingDto.Rate;
                
                await _unitOfWork.Commit();
            }
            else
            {
                var rating = ratingDto.Adapt<Rating>();
                
                _unitOfWork.RatingRepository.Insert(rating);

                await _unitOfWork.Commit();
            }


        }

        public async Task Delete(int ratingId)
        {
            var rating = await _unitOfWork.RatingRepository.GetById(ratingId);
            
            _unitOfWork.RatingRepository.Remove(rating);

            await _unitOfWork.Commit();
        }
    }
}