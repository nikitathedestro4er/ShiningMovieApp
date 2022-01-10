using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Services.Abstractions
{
    public interface IServiceManager
    {
        IMovieService MovieService { get; }
        
        ICustomerService CustomerService { get; }

        IGenreService GenreService { get; }

        IDirectorService DirectorService { get; }

        IActorService ActorService { get;  }
        
        ICommentService CommentService { get; }
        
        IRatingService RatingService { get; }


    }
}
