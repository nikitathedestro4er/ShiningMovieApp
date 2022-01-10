using DTOs.Director;
using Services.QueryStringParameters;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Services.Abstractions
{
    public interface IDirectorService
    {
        Task<PagedList<DirectorForListDTO>> GetAll(DirectorParameters parameters);

        Task<DirectorDTO> GetById(int directorId);

        Task<DirectorDTO> Create(DirectorForCreationDTO directorForCreationDTO);

        Task Update(int directorId, DirectorForUpdateDTO directorForUpdateDTO);

        Task Delete(int directorId);
    }
}
