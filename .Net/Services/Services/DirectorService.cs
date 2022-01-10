using DTOs.Director;
using Domain.Exceptions;
using Domain.Services.Repositories;
using Mapster;
using Services.Abstractions;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Domain.Entities;
using Services.QueryStringParameters;
using Services.Extensions;

namespace Services.Services
{
    internal sealed class DirectorService : IDirectorService
    {
        private const string ImagesFolderName = "Images";

        private readonly IUnitOfWork _unitOfWork;

        private readonly IFileService _fileService;

        public DirectorService(IUnitOfWork unitOfWork, IFileService fileService)
        {
            _unitOfWork = unitOfWork;
            _fileService = fileService;
        }



        public async Task<PagedList<DirectorForListDTO>> GetAll(DirectorParameters parameters)
        {
            var directors = await _unitOfWork.DirectorRepository.GetAll();

            var directorsDto = directors
                .Search(parameters)
                .Sort(parameters)
                .Select(Map)
                .ToList();

            return PagedList<DirectorForListDTO>.ToPagedList(directorsDto, parameters.PageNumber, parameters.PageSize);

            DirectorForListDTO Map(Director director)
            {
                var dto = director.Adapt<DirectorForListDTO>();

                return dto;
            }
        }


        public async Task<DirectorDTO> GetById(int directorId)
        {
            var director = await _unitOfWork.DirectorRepository.GetById(directorId);

            if (director is null)
            {
                throw new DirectorNotFoundException(directorId);
            }

            var directorDTO = director.Adapt<DirectorDTO>();

            directorDTO.Image = _fileService.GetFilePath($"{ImagesFolderName}/{director.Image}");

            foreach (var movie in directorDTO.Movies)
            {
                movie.Image = _fileService.GetFilePath($"{ImagesFolderName}/{movie.Image}");
            }

            return directorDTO;
        }


        public async Task<DirectorDTO> Create(DirectorForCreationDTO directorForCreationDTO)
        {
            var imageName = _fileService.CreateImageName(directorForCreationDTO.Name, directorForCreationDTO.FileExtension);

            await _fileService.Save(directorForCreationDTO.File, $"{ImagesFolderName}/{imageName}");

            var director = directorForCreationDTO.Adapt<Director>();

            director.Image = imageName;

            _unitOfWork.DirectorRepository.Insert(director);

            await _unitOfWork.Commit();

            var directorFromDb = await _unitOfWork.DirectorRepository.GetById(director.Id);

            return directorFromDb.Adapt<DirectorDTO>();
        }



        public async Task Update(int directorId, DirectorForUpdateDTO directorForUpdateDTO)
        {
            var director = await _unitOfWork.ActorRepository.GetById(directorId);

            if (director is null)
            {
                throw new DirectorNotFoundException(directorId);
            }



            if (directorForUpdateDTO.FileExtension != null)
            {
                await _fileService.Delete($"{ImagesFolderName}/{director.Image}");

                var imageName = _fileService.CreateImageName(directorForUpdateDTO.Name, directorForUpdateDTO.FileExtension);

                await _fileService.Save(directorForUpdateDTO.File, $"{ImagesFolderName}/{imageName}");

                director.Image = imageName;
            }



            director.Name = directorForUpdateDTO.Name;
            director.Birthday = directorForUpdateDTO.Birthday;
            director.Rating = directorForUpdateDTO.Rating;
            director.Description = directorForUpdateDTO.Description;
            director.ModifiedDate = DateTime.UtcNow;

            await _unitOfWork.Commit();
        }




        public async Task Delete(int directorId)
        {
            var director = await _unitOfWork.DirectorRepository.GetById(directorId);

            if (director is null)
            {
                throw new DirectorNotFoundException(directorId);
            }

            await _fileService.Delete($"{ImagesFolderName}/{director.Image}");

            _unitOfWork.DirectorRepository.Remove(director);

            await _unitOfWork.Commit();
        }


    }
}
