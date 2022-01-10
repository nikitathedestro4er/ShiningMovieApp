using Domain.Services.Repositories;
using Services.Abstractions;
using System;

namespace Services.Services
{
    public sealed class ServiceManager : IServiceManager
    {

        public ServiceManager(IUnitOfWork unitOfWork, IFileService fileService)
        {
            MovieService = new MovieService(unitOfWork, fileService);

            CustomerService = new CustomerService(unitOfWork, fileService);

            ActorService = new ActorService(unitOfWork, fileService);

            DirectorService = new DirectorService(unitOfWork, fileService);

            GenreService = new GenreService(unitOfWork);

            CommentService = new CommentService(unitOfWork, fileService);

            RatingService = new RatingService(unitOfWork);
        }


        public IMovieService MovieService { get; }
        
        
        public ICustomerService CustomerService { get; }

        public IGenreService GenreService { get; }

        public IDirectorService DirectorService { get; }

        public IActorService ActorService { get; }

        public ICommentService CommentService { get; }
        
        public IRatingService RatingService { get; }
    }
}
