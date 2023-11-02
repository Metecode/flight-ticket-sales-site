using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FlightTicketSalesSite.Entity
{
    public class Ticket
    {
        public int TicketId { get; set; }
        public int AirplaneId { get; set; }
        public Airplane Airplane { get; set; }
        public Passenger Passenger { get; set; }
        public int PassengerId { get; set; }
        public Trip Trip { get; set; }
        public int TripId { get; set; }
        [Required()]
        public int SeatNo { get; set; }


    }
}
