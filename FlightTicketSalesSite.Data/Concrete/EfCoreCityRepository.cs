using FlightTicketSalesSite.Data.Abstract;
using FlightTicketSalesSite.Entity;
using FlightTicketSalesSite.Data.Concrete;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FlightTicketSalesSite.Data.Concrete
{
    public class EfCoreCityRepository : EfCoreGenericRepository<City>, ICityRepository
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
