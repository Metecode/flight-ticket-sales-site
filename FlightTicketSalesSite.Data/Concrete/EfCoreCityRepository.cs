using FlightTicketSalesSite.Data.Abstract;
using FlightTicketSalesSite.Entity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;

namespace FlightTicketSalesSite.Data.Concrete
{
    internal class EfCoreCityRepository : EfCoreGenericRepository<City>, ICityRepository
    {
        public EfCoreCityRepository(AirplaneContext _dbContext) : base(_dbContext)
        {

        }
        private AirplaneContext context
        {
            get
            {
                return _dbContext as AirplaneContext;
            }
        }

        public async Task<List<City>> GellAllCitiesAsync(int id)
        {

            return await context
                .Set<City>()
                .ToListAsync();
        }
    }
}
