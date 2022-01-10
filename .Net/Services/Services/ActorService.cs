using Domain.Entities;
using Domain.Exceptions;
using Domain.Services.Repositories;
using DTOs.Actor;
using Mapster;
using Services.Abstractions;
using Services.Extensions;
using Services.QueryStringParameters;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Services.Services
{
    internal sealed class ActorService : IActorService
    {

        private const string ImagesFolderName = "Images";

        private readonly IUnitOfWork _unitOfWork;

        private readonly IFileService _fileService;

        public ActorService(IUnitOfWork unitOfWork, IFileService fileService)
        {
            _unitOfWork = unitOfWork;

            _fileService = fileService;
        }
 


        public async Task<PagedList<ActorForListDTO>> GetAll(ActorParameters parameters)
        {
            var actors = await _unitOfWork.ActorRepository.GetAll();


            var actorsDto = actors
                .Search(parameters)
                .Sort(parameters)
                .Select(Map)
                .ToList();

            return PagedList<ActorForListDTO>.ToPagedList(actorsDto, parameters.PageNumber, parameters.PageSize);

            ActorForListDTO Map(Actor actor)
            {
                var dto = actor.Adapt<ActorForListDTO>();

                return dto;
            }
        }


        public async Task<ActorDTO> GetById(int actorId)
        {
            var actor = await _unitOfWork.ActorRepository.GetById(actorId);

            if (actor is null)
            {
                throw new ActorNotFoundException(actorId);
            }

            var actorDTO = actor.Adapt<ActorDTO>();

            actorDTO.Image = _fileService.GetFilePath($"{ImagesFolderName}/{actor.Image}");

            foreach (var movie in actorDTO.Movies)
            {
                movie.Image = _fileService.GetFilePath($"{ImagesFolderName}/{movie.Image}");
            }


            return actorDTO;
        }


        public async Task<ActorDTO> Create(ActorForCreationDTO actorForCreationDTO)
        {
            var imageName = _fileService.CreateImageName(actorForCreationDTO.Name, actorForCreationDTO.FileExtension);

            await _fileService.Save(actorForCreationDTO.File, $"{ImagesFolderName}/{imageName}");

            var actor = actorForCreationDTO.Adapt<Actor>();

            actor.Image = imageName;

            _unitOfWork.ActorRepository.Insert(actor);

            await _unitOfWork.Commit();

            var actorFromDb = await _unitOfWork.ActorRepository.GetById(actor.Id);

            return actorFromDb.Adapt<ActorDTO>();
        }



        public async Task Update(int actorId, ActorForUpdateDTO actorForUpdateDTO)
        {
            var actor = await _unitOfWork.ActorRepository.GetById(actorId);

            if (actor is null)
            {
                throw new ActorNotFoundException(actorId);
            }



            if (actorForUpdateDTO.FileExtension != null)
            {
                await _fileService.Delete($"{ImagesFolderName}/{actor.Image}");

                var imageName = _fileService.CreateImageName(actorForUpdateDTO.Name, actorForUpdateDTO.FileExtension);

                await _fileService.Save(actorForUpdateDTO.File, $"{ImagesFolderName}/{imageName}");

                actor.Image = imageName;
            }



            actor.Name = actorForUpdateDTO.Name;
            actor.Birthday = actorForUpdateDTO.Birthday;
            actor.Rating = actorForUpdateDTO.Rating;
            actor.Description = actorForUpdateDTO.Description;
            actor.ModifiedDate = DateTime.UtcNow;

            await _unitOfWork.Commit();
        }




        public async Task Delete(int actorId)
        {
            var actor = await _unitOfWork.ActorRepository.GetById(actorId);

            if (actor is null)
            {
                throw new ActorNotFoundException(actorId);
            }

            await _fileService.Delete($"{ImagesFolderName}/{actor.Image}");

            _unitOfWork.ActorRepository.Remove(actor);

            await _unitOfWork.Commit();
        }


    }
}
