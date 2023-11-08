using FlightTicketSalesSite.Entity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FlightTicketSalesSite.Service.Abstract
{
    public interface IPassengerService
    {
        Task<Passenger> GetByIdAsync(int id);
        Task<List<Passenger>> GetAllAsync();
        Task CreateAsync(Passenger passenger);
        void Update(Passenger passenger);
        void Delete(int id);
        Task CreateAsync(Passenger passenger, int seatNumber, int id);

    }
}
