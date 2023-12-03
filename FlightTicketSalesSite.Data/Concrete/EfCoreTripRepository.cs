using FlightTicketSalesSite.Data.Abstract;
using FlightTicketSalesSite.Entity;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FlightTicketSalesSite.Data.Concrete
{
    public class EfCoreTripRepository : EfCoreGenericRepository<Trip>, ITripRepository
    {
        public EfCoreTripRepository(AirplaneContext _dbContext) : base(_dbContext)
        {

        }
        private AirplaneContext? context
        {
            get
            {
                return _dbContext as AirplaneContext;
            }
        }

        public Task<Trip> GetAirplaneInfo(int id)
        {
            throw new NotImplementedException();
        }

        public decimal GetPrice(int id)
        {
            return context
                .Trips
                .Where(t => t.TripId == id)
                .Select(t => t.Price)
                .FirstOrDefault();
        }

        public async Task<Trip> GetSeatCapacity(int id)
        {
            return await context
                .Trips
                .Where(t => t.TripId == id)
                .Include(t => t.Tickets)
                .Include(t => t.Airplane)
                .FirstOrDefaultAsync();
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

        public async Task<Trip> GetTripById(int id)
        {
            return await context
                .Trips
                .Where(t => t.TripId == id)
                .Include(t => t.FromWhere)
                .Include(t => t.ToWhere)
                .FirstOrDefaultAsync();
        }

        public int GetTrips(int tripId)
        {
            return context
                .Trips
                .Where(t => t.TripId == tripId)
                .Include(t => t.Tickets)
                .Include(t => t.Airplane.AirplaneId)
                .Select(t => t.Airplane.SeatCapacity)
                .FirstOrDefault();




        }

        public async Task<List<Trip>> GetTripsAsync(int fromWhereId, int toWhereId, DateTime tripDate)
        {
            return await context
                .Trips
                .Where(t => t.FromWhereId == fromWhereId && t.ToWhereId == toWhereId && t.TripDate == tripDate)
                .Include(t => t.FromWhere)
                .Include(t => t.ToWhere)
                .ToListAsync();
        }
    }
}
