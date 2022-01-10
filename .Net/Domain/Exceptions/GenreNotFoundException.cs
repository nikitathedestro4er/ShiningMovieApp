using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain.Exceptions
{
    public sealed class GenreNotFoundException : NotFoundException
    {
        public GenreNotFoundException(int genreId) : base($"The genre with the identifier {genreId} was not found.")
        {

        }
    }
}
