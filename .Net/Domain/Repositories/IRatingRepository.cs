using System.Collections.Generic;
using System.Threading.Tasks;
using Domain.Entities;

namespace Domain.Services.Repositories
{
    public interface IRatingRepository
    {
        Task<IEnumerable<Rating>> GetAllByMovie(int movieId);

        Task<Rating> GetByCustomer(int customerId);
        
        Task<Rating> GetById(int ratingId);
        
        void Insert(Rating rating);

        void Remove(Rating rating);
    }
}