using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using FlightTicketSalesSite.Entity;

namespace FlightTicketSalesSite.Data.Abstract
{
    public interface IAirplaneRepository : IRepository<Airplane>
    {
        int GetSeats(int id);
    }
}
