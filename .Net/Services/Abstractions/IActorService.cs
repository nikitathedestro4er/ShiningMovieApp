using DTOs.Actor;
using Services.QueryStringParameters;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Services.Abstractions
{
    public interface IActorService
    {

        Task<PagedList<ActorForListDTO>> GetAll(ActorParameters parameters);

        Task<ActorDTO> GetById(int actorId);

        Task<ActorDTO> Create(ActorForCreationDTO actorForCreationDTO);

        Task Update(int actorId, ActorForUpdateDTO actorForUpdateDTO);

        Task Delete(int actorId);
    }
}
