using System.Collections.Generic;
using System.Threading.Tasks;
using Domain.Entities;
using Domain.Exceptions;
using Domain.Services.Repositories;
using DTOs.Customer;
using Mapster;
using Services.Abstractions;

namespace Services.Services
{
    internal sealed class CustomerService : ICustomerService
    {
        
        private const string ImagesFolderName = "Images";

        private readonly IUnitOfWork _unitOfWork;

        private readonly IFileService _fileService;

        public CustomerService(IUnitOfWork unitOfWork, IFileService fileService)
        {
            _unitOfWork = unitOfWork;
            _fileService = fileService;

        }
        
        
        public async Task<List<CustomerDTO>> GetAll()
        {
            var customers = await _unitOfWork.CustomerRepository.GetAll();

            return customers.Adapt<List<CustomerDTO>>();

        }

        public async Task<CustomerDTO> GetByUserId(string userId)
        {
            var customer = await _unitOfWork.CustomerRepository.GetByUserId(userId);
            
            
            if (customer is null)
            {
                throw new CustomerNotFoundException(userId);
            }

            var customerDTO = customer.Adapt<CustomerDTO>();
            
            customerDTO.Image = _fileService.GetFilePath($"{ImagesFolderName}/{customer.Image}");
            
            return customerDTO;
        }

        public async Task<CustomerDTO> Create(CustomerForCreationDTO customerForCreationDTO)
        {
            var imageName = _fileService.CreateImageName(customerForCreationDTO.UserId, customerForCreationDTO.FileExtension);

            await _fileService.Save(customerForCreationDTO.File , $"{ImagesFolderName}/{imageName}");

            var customer = customerForCreationDTO.Adapt<Customer>();

            customer.Image = imageName;

            _unitOfWork.CustomerRepository.Insert(customer);

            await _unitOfWork.Commit();

            var customerFromDb = await _unitOfWork.CustomerRepository.GetById(customer.Id);

            return customerFromDb.Adapt<CustomerDTO>();
        }

        public async Task Update(int customerId, CustomerForUpdateDTO customerForUpdateDTO)
        {
            var customer = await _unitOfWork.CustomerRepository.GetById(customerId);

            if (customer is null)
            {
                throw new CustomerNotFoundException(customerId);
            }



            if (customerForUpdateDTO.FileExtension != null)
            {
                await _fileService.Delete($"{ImagesFolderName}/{customer.Image}");

                var imageName = _fileService.CreateImageName(customerForUpdateDTO.UserId, customerForUpdateDTO.FileExtension);

                await _fileService.Save(customerForUpdateDTO.File, $"{ImagesFolderName}/{imageName}");

                customer.Image = imageName;
            }



            await _unitOfWork.Commit();
        }

        public async Task Delete(int customerId)
        {
            var customer = await _unitOfWork.CustomerRepository.GetById(customerId);

            if (customer is null)
            {
                throw new CustomerNotFoundException(customerId);
            }

            await _fileService.Delete($"{ImagesFolderName}/{customer.Image}");

            _unitOfWork.CustomerRepository.Remove(customer);

            await _unitOfWork.Commit();
        }
    }
}