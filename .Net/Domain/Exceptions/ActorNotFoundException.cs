using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain.Exceptions
{
    public sealed class ActorNotFoundException : NotFoundException
    {
        public ActorNotFoundException(int actorId) : base($"The actor with the identifier {actorId} was not found.")
        {

        }
    }
}
