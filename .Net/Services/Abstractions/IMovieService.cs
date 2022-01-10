using Services;
using DTOs.Movie;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Services.QueryStringParameters;

namespace Services.Abstractions
{
    public interface IMovieService
    {
        Task<PagedList<MovieForListDTO>> GetAll(MovieParameters parameters);

        Task<MovieDTO> GetById(int movieId);

        Task<MovieDTO> Create(MovieForCreationDTO movieForCreationDTO);

        Task Update(int movieId, MovieForUpdateDTO movieForUpdateDTO);

        Task Delete(int movieId);
    }
}
