using System.Collections.Generic;
using System.Threading.Tasks;
using DTOs.Customer;
using DTOs.Movie;

namespace Services.Abstractions
{
    public interface ICustomerService
    {
        Task<List<CustomerDTO>> GetAll();

        Task<CustomerDTO> GetByUserId(string userId);

        Task<CustomerDTO> Create(CustomerForCreationDTO customerForCreationDTO);

        Task Update(int customerId, CustomerForUpdateDTO customerForUpdateDTO);

        Task Delete(int customerId);
    }
}