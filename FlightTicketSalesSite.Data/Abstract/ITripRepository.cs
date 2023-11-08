using FlightTicketSalesSite.Entity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FlightTicketSalesSite.Data.Abstract
{
    public interface ITripRepository
    {
        Task<List<Trip>> GetTripsAsync(int fromWhereId, int toWhereId, DateTime tripDate);
        int GetTrips(int tripId);
        public Task<Trip> GetSeatCapacity(int id);
        Task<Trip> GetAirplaneInfo(int id);
        Task<Trip> GetTripById(int id);
        int GetSeats(int id);
        decimal GetPrice(int id);
        Task CreateAsync(Trip trip);
        void Delete(Trip trip);
        Task<List<Trip>> GetAllAsync();
        Task<Trip> GetByIdAsync(int id);
        void Update(Trip trip);
    }
}
