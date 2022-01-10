using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Domain.Entities;
using Domain.Services.Repositories;
using Infrastructure.DbContexts;
using Microsoft.EntityFrameworkCore;

namespace Infrastructure.Repositories
{
    public class RatingRepository : IRatingRepository
    {
        private readonly DataContext _dataContext;
        
        public RatingRepository(DataContext dataContext)
        {
            _dataContext = dataContext;
        }
        
        public async Task<IEnumerable<Rating>> GetAllByMovie(int movieId)
        {
            return await _dataContext.Ratings.Where(x => x.MovieId == movieId).ToListAsync();
        }

        
        public async Task<Rating> GetByCustomer(int customerId)
        {
            return await _dataContext.Ratings.FirstOrDefaultAsync(x => x.CustomerId == customerId);
        }
        

        public async Task<Rating> GetById(int ratingId)
        {
            return await _dataContext.Ratings.FirstOrDefaultAsync(x => x.Id == ratingId);
        }
        
        
        public void Insert(Rating rating)
        {
            _dataContext.Ratings.Add(rating);
        }

        public void Remove(Rating rating)
        {
            _dataContext.Ratings.Remove(rating);
        }
    }
}