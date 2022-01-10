using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain.Exceptions
{
    public sealed class MovieNotFoundException : NotFoundException
    {
        public MovieNotFoundException(int movieId) : base($"The movie with the identifier {movieId} was not found.")
        {

        }
    }
}
