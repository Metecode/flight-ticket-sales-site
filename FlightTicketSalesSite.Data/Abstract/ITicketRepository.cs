using FlightTicketSalesSite.Entity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FlightTicketSalesSite.Data.Abstract
{
    internal interface ITicketRepository
    {
        Task<Ticket> GetTicketDetails(int id);
        Task<Ticket> GetTicketByTrip(int id);
        List<int> GetReservedSeat(int id);
    }
}
