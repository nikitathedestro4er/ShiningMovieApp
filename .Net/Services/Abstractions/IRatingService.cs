using System.Collections.Generic;
using System.Threading.Tasks;
using DTOs.Customer;
using DTOs.Rating;

namespace Services.Abstractions
{
    public interface IRatingService
    {
        Task<List<RatingDTO>> GetAllByMovie(int movieId);


        Task<RatingDTO> GetById(int ratingId);
        
        Task Create(RatingDTO ratingDto);

        Task Delete(int ratingId);
    }
}