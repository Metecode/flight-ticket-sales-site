using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using FlightTicketSalesSite.Data.Abstract;
using FlightTicketSalesSite.Entity;
using Microsoft.EntityFrameworkCore;

namespace FlightTicketSalesSite.Data.Concrete
{
    public class EfCoreAirplaneRepository : EfCoreGenericRepository<Airplane>, IAirplaneRepository
    {
        public EfCoreAirplaneRepository(AirplaneContext _dbContext) : base(_dbContext)
        {

        }
        private AirplaneContext context
        {
            get
            {
                return _dbContext as AirplaneContext;
            }
        }

        public int GetSeats(int id)
        {
            var result = context
                .Trips
                .Where(t => t.TripId == id)
                .Include(t => t.Airplane)
                .FirstOrDefault();
            return result.Airplane.SeatCapacity;
        }
    }
}
