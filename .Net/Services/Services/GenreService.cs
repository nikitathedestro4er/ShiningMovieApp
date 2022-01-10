using DTOs.Genre;
using Domain.Exceptions;
using Domain.Services.Repositories;
using Mapster;
using Services.Abstractions;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace Services.Services
{
    internal sealed class GenreService : IGenreService
    {
        private readonly IUnitOfWork _unitOfWork;

        public GenreService(IUnitOfWork unitOfWork) => _unitOfWork = unitOfWork;



        public async Task<IEnumerable<GenreDTO>> GetAll()
        {
            var genres = await _unitOfWork.GenreRepository.GetAll();

            var genresDTO = genres.Adapt<IEnumerable<GenreDTO>>();

            return genresDTO;
        }


        public async Task<GenreDTO> GetById(int genreId)
        {
            var genre = await _unitOfWork.GenreRepository.GetById(genreId);

            if (genre is null)
            {
                throw new GenreNotFoundException(genreId);
            }

            var genreDto = genre.Adapt<GenreDTO>();

            return genreDto;
        }
    }
}
