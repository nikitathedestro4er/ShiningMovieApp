using Domain.Entities;
using Domain.Exceptions;
using Domain.Services.Repositories;
using Mapster;
using System.Collections.Generic;
using System.Threading.Tasks;
using Services.Extensions;
using Services.Abstractions;
using Services.QueryStringParameters;
using DTOs.Movie;
using System.Linq;
using System.IO;
using System;

namespace Services.Services
{
    internal sealed class MovieService : IMovieService
    {
        private const string ImagesFolderName = "Images";

        private readonly IUnitOfWork _unitOfWork;

        private readonly IFileService _fileService;

        public MovieService(IUnitOfWork unitOfWork, IFileService fileService)
        {
            _unitOfWork = unitOfWork;
            _fileService = fileService;

        }



        public async Task<PagedList<MovieForListDTO>> GetAll(MovieParameters parameters)
        {
            var movies = await _unitOfWork.MovieRepository.GetAll();

            var moviesDto = movies               
                .Filter(parameters)
                .Search(parameters)
                .Sort(parameters)
                .Select(Map)
                .ToList();


            return PagedList<MovieForListDTO>.ToPagedList(moviesDto, parameters.PageNumber, parameters.PageSize);

            MovieForListDTO Map(Movie movie)
            {
                var dto = movie.Adapt<MovieForListDTO>();

                dto.Image = _fileService.GetFilePath($"{ImagesFolderName}/{dto.Image}");

                return dto;
            }
        }


        public async Task<MovieDTO> GetById(int movieId)
        {
            var movie = await _unitOfWork.MovieRepository.GetById(movieId);

            await CalculateRating(movie);

            var movies = await _unitOfWork.MovieRepository.GetAll();


            if (movie is null || movies is null)
            {
                throw new MovieNotFoundException(movieId);
            }

            var relatedMovies = movies.Where(x =>
                x.DirectorId == movie.DirectorId || x.GenreId == movie.GenreId).Where(x => x.Id != movie.Id);

                
            

            var movieDto = movie.Adapt<MovieDTO>();

            movieDto.Image = _fileService.GetFilePath($"{ImagesFolderName}/{movie.Image}");

            movieDto.Director.Image = _fileService.GetFilePath($"{ImagesFolderName}/{movieDto.Director.Image}");

            foreach (var actor in movieDto.Actors)
            {
                actor.Image = _fileService.GetFilePath($"{ImagesFolderName}/{actor.Image}");
            }


            movieDto.RelatedMovies = relatedMovies.Adapt<ICollection<DTOs.Shared.Movie>>();
            

            foreach (var relatedMovie in movieDto.RelatedMovies)
            {
                relatedMovie.Image = _fileService.GetFilePath($"{ImagesFolderName}/{relatedMovie.Image}");
            }

            return movieDto;
        }


        public async Task<MovieDTO> Create(MovieForCreationDTO movieForCreationDTO)
        {
            var imageName = _fileService.CreateImageName(movieForCreationDTO.Name, movieForCreationDTO.FileExtension);

            await _fileService.Save(movieForCreationDTO.File , $"{ImagesFolderName}/{imageName}");

            var movie = movieForCreationDTO.Adapt<Movie>();

            movie.Image = imageName;



            await AddActors(movieForCreationDTO.Actors, movie.Actors);

            

            _unitOfWork.MovieRepository.Insert(movie);

            await _unitOfWork.Commit();

            var movieFromDb = await _unitOfWork.MovieRepository.GetById(movie.Id);

            return movieFromDb.Adapt<MovieDTO>();
        }



        public async Task Update(int movieId, MovieForUpdateDTO movieForUpdateDTO)
        {
            var movie = await _unitOfWork.MovieRepository.GetById(movieId);

            if (movie is null)
            {
                throw new MovieNotFoundException(movieId);
            }



            if (movieForUpdateDTO.FileExtension != null)
            {
                await _fileService.Delete($"{ImagesFolderName}/{movie.Image}");

                var imageName = _fileService.CreateImageName(movieForUpdateDTO.Name, movieForUpdateDTO.FileExtension);

                await _fileService.Save(movieForUpdateDTO.File, $"{ImagesFolderName}/{imageName}");

                movie.Image = imageName;
            }



            movie.Name = movieForUpdateDTO.Name;
            movie.GenreId = movieForUpdateDTO.GenreId;
            movie.DirectorId = movieForUpdateDTO.DirectorId;


            await UpdateActors(movieForUpdateDTO.Actors, movie.Actors);


            movie.Year = movieForUpdateDTO.Year;
            movie.Rating = movieForUpdateDTO.Rating;
            movie.Description = movieForUpdateDTO.Description;
            movie.ModifiedDate = DateTime.UtcNow;

            await _unitOfWork.Commit();
        }




        public async Task Delete(int movieId)
        {
            var movie = await _unitOfWork.MovieRepository.GetById(movieId);

            if (movie is null)
            {
                throw new MovieNotFoundException(movieId);
            }

            await _fileService.Delete($"{ImagesFolderName}/{movie.Image}");

            _unitOfWork.MovieRepository.Remove(movie);

            await _unitOfWork.Commit();
        }






        private async Task CalculateRating(Movie movie)
        {
            var ratings = await _unitOfWork.RatingRepository.GetAllByMovie(movie.Id);

            var rating = ratings.Select(x => x.Rate).DefaultIfEmpty(0).Average();

            
            
        }
        
        
         
        
        private async Task AddActors(ICollection<DTOs.Shared.Actor> actorsForAdding, ICollection<Actor> currentActors)
        {
            currentActors.Clear();

            foreach (var actor in actorsForAdding)
            {
                var actorFromDb = await _unitOfWork.ActorRepository.GetById(actor.Id);
                currentActors.Add(actorFromDb);
            }
        }


        private async Task UpdateActors(ICollection<DTOs.Shared.Actor> actorsForUpdate, ICollection<Actor> currentActors)
        {
            var actorsForAdding = actorsForUpdate.ToList();

            foreach (var actor in actorsForAdding)
            {
                if (currentActors.Any(c => c.Id == actor.Id))
                {
                    actorsForUpdate.Remove(actor);
                }
            }

            var actorsForDeleting = currentActors.ToList();

            foreach (var actor in actorsForDeleting)
            {
                if (!actorsForAdding.Any(c => c.Id == actor.Id))
                {
                    currentActors.Remove(actor);
                }
            }


            foreach (var actor in actorsForUpdate)
            {
                var actorFromDb = await _unitOfWork.ActorRepository.GetById(actor.Id);
                currentActors.Add(actorFromDb);
            }
        }

    }
}
