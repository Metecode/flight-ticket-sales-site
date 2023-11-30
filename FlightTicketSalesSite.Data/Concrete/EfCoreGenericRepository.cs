using FlightTicketSalesSite.Data.Abstract;
using FlightTicketSalesSite.Entity;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace FlightTicketSalesSite.Data.Concrete
{
    public class EfCoreGenericRepository<TEntity> : IRepository<TEntity> where TEntity : class
    {
        protected readonly DbContext _dbContext;
        private Airplane dbContext;

        public EfCoreGenericRepository(DbContext dbContext)
        {
            _dbContext = dbContext;
        }

        public EfCoreGenericRepository(Airplane dbContext)
        {
            this.dbContext = dbContext;
        }

        public async Task CreateAsync(TEntity entity)
        {
            await _dbContext.AddAsync(entity);
            await _dbContext.SaveChangesAsync();
        }

        public void Delete(TEntity entity)
        {
            _dbContext.Remove(entity);
            _dbContext.SaveChanges();
        }

        public Task<List<City>> GellAllCitiesAsync(int id)
        {
            throw new NotImplementedException();
        }

        public async Task<List<TEntity>> GetAllAsync()
        {
            return await _dbContext
                .Set<TEntity>()
                .ToListAsync();
        }

        public async Task<TEntity> GetByIdAsync(int id)
        {
            return await _dbContext
                .Set<TEntity>()
                .FindAsync(id);
        }

        public void Update(TEntity entity)
        {
            _dbContext.Set<TEntity>().Update(entity);
            _dbContext.SaveChanges();
        }
    }
}
