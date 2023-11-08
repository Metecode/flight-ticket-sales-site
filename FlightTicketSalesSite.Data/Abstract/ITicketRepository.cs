using FlightTicketSalesSite.Entity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FlightTicketSalesSite.Data.Abstract
{
    public interface ITicketRepository
    {
        Task<Ticket> GetTicketDetails(int id);
        Task<Ticket> GetTicketByTrip(int id);
        List<int> GetReservedSeat(int id);
        Task CreateAsync(Ticket ticket);
        void Delete(Ticket ticket);
        Task<List<Ticket>> GetAllAsync();
        Task<Ticket> GetByIdAsync(int id);
        void Update(Ticket ticket);
    }
}
