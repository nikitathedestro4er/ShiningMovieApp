using Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain.Services.Repositories
{
    public interface IUnitOfWork
    {
        public IRepository<Movie> MovieRepository { get; }
        
        public ICustomerRepository CustomerRepository { get; }
        public IRepository<Genre> GenreRepository { get; }
        public IRepository<Director> DirectorRepository { get; }
        public IRepository<Actor> ActorRepository { get; }
        public IRepository<Comment> CommentRepository { get;}
        
        public IRatingRepository RatingRepository { get; }

        Task<int> Commit();

    }
}
