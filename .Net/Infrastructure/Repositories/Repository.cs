using Domain.Services.Repositories;
using Infrastructure.DbContexts;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Infrastructure.Repositories
{
    internal sealed class Repository<T> : IRepository<T> where T : class
    {

        private readonly DataContext _dataContext;

        private readonly DbSet<T> _dbSet;

        public Repository(DataContext dataContext)
        {
            _dataContext = dataContext;

            _dbSet = _dataContext.Set<T>();
        }

        public async Task<IEnumerable<T>> GetAll() => await _dbSet.ToListAsync();


        public async Task<T> GetById(int Id) => await _dbSet.FindAsync(Id);


        public void Insert(T entity) => _dbSet.Add(entity);


        public void Remove(T entity) => _dbSet.Remove(entity);
    }
}
