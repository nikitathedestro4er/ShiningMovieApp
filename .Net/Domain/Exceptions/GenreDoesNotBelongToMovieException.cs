using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain.Exceptions
{
    public sealed class GenreDoesNotBelongToMovieException : BadRequestException
    {
        public GenreDoesNotBelongToMovieException(int genreId, int movieId) 
            : base($"The genre with the identifier {genreId} does not belong to the movie with identifier {movieId}")
        {

        }
    }
}
