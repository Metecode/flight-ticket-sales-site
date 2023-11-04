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
    public class EfCorePassengerRepository : EfCoreGenericRepository<Passenger>, IPassengerRepository
    {
        public EfCorePassengerRepository(AirplaneContext _dbContext) : base(_dbContext)
        {

        }
        private AirplaneContext context
        {
            get
            {
                return _dbContext as AirplaneContext;
            }
        }

        public async Task CreateAsync(Passenger passenger, int seatNumber, int id)
        {
            await context.Passengers.AddAsync(passenger);
            await context.SaveChangesAsync();

            var ticket = context.Tickets
                .Select(ticket => new Ticket
                {
                    PassengerId = passenger.PassengerId,
                    TripId = id,
                    SeatNo = seatNumber,
                    AirplaneId = id
                }).FirstOrDefault();
            await context.Tickets.AddAsync(ticket);
            await context.SaveChangesAsync();
        }

    }
}
