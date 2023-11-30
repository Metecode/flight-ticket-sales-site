using FlightTicketSalesSite.Entity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FlightTicketSalesSite.Data.Abstract
{
    public interface IRepository<TEntity>
    {
        Task CreateAsync(TEntity entity);
        void Delete(TEntity entity);
        Task<List<City>> GellAllCitiesAsync(int id);
        Task<List<TEntity>> GetAllAsync();
        Task<TEntity> GetByIdAsync(int id);
        void Update(TEntity entity);
    }
}
