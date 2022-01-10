using System.Collections.Generic;
using System.Threading.Tasks;
using Domain.Entities;
using Domain.Services.Repositories;
using Infrastructure.DbContexts;
using Microsoft.EntityFrameworkCore;

namespace Infrastructure.Repositories
{
    public class CustomerRepository : ICustomerRepository
    {
        private readonly DataContext _dataContext;
        

        public CustomerRepository(DataContext dataContext)
        {
            _dataContext = dataContext;
            
        }

        public async Task<IEnumerable<Customer>> GetAll() => await _dataContext.Customers.ToListAsync();


        public async Task<Customer> GetById(int Id) => await _dataContext.Customers.FindAsync(Id);
        
        
        public async Task<Customer> GetByUserId(string userId) => await _dataContext.Customers.FirstOrDefaultAsync(x => x.UserId == userId);


        public void Insert(Customer customer) => _dataContext.Customers.Add(customer);


        public void Remove(Customer customer) => _dataContext.Customers.Remove(customer);
    }
}