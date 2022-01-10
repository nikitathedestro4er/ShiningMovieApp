using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain.Exceptions
{
    public sealed class DirectorNotFoundException : NotFoundException
    {
        public DirectorNotFoundException(int directorId) : base($"The director with the identifier {directorId} was not found.")
        {

        }
    }
}
