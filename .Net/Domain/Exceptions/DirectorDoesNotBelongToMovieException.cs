using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain.Exceptions
{
    public sealed class DirectorDoesNotBelongToMovieException : BadRequestException
    {
        public DirectorDoesNotBelongToMovieException(int directorId, int movieId)
            : base($"The director with the identifier {directorId} does not belong to the movie with identifier {movieId}")
        {

        }
    }
}
