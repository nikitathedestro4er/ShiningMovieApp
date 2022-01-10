using DTOs.Genre;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Services.Abstractions
{
    public interface IGenreService
    {
        Task<IEnumerable<GenreDTO>> GetAll();

        Task<GenreDTO> GetById(int genreId);
    }
}
