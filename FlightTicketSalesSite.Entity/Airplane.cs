using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Sockets;
using System.Text;
using System.Threading.Tasks;

namespace FlightTicketSalesSite.Entity
{
    public class Airplane
    {
        public int AirplaneId { get; set; }
        public int SeatCapacity { get; set; }
        public List<Ticket> Tickets { get; set; }
        public List<Trip> Trips { get; set; }
    }
}
