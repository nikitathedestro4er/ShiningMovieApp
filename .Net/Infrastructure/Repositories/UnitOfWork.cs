using Domain.Entities;
using Domain.Services.Repositories;
using Infrastructure.DbContexts;
using System.Threading.Tasks;

namespace Infrastructure.Repositories
{
    public sealed class UnitOfWork : IUnitOfWork
    {
        private readonly DataContext _dataContext;


        public UnitOfWork(DataContext dataContext)
        {
            _dataContext = dataContext;

            MovieRepository = new Repository<Movie>(dataContext);

            CustomerRepository = new CustomerRepository(dataContext);

            GenreRepository = new Repository<Genre>(dataContext);

            DirectorRepository = new Repository<Director>(dataContext);

            ActorRepository = new Repository<Actor>(dataContext);

            CommentRepository = new Repository<Comment>(dataContext);

            RatingRepository = new RatingRepository(dataContext);
        }



        public IRepository<Movie> MovieRepository { get; }
        
        public ICustomerRepository CustomerRepository { get; }

        public IRepository<Genre> GenreRepository { get; }

        public IRepository<Director> DirectorRepository { get; }

        public IRepository<Actor> ActorRepository { get; }

        public IRepository<Comment> CommentRepository { get; }     
        
        public IRatingRepository RatingRepository { get; }

        public Task<int> Commit() => _dataContext.SaveChangesAsync();
    }
}
