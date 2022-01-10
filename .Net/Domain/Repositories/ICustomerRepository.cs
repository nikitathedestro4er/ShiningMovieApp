using System.Collections.Generic;
using System.Threading.Tasks;
using Domain.Entities;

namespace Domain.Services.Repositories
{
    public interface ICustomerRepository
    {
        Task<IEnumerable<Customer>> GetAll();

        Task<Customer> GetById(int Id);
        
        Task<Customer> GetByUserId(string userId);

        void Insert(Customer customer);

        void Remove(Customer customer);
    }
}