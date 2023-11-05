using FlightTicketSalesSite.Entity;

namespace FlightTicketSalesSite.Models
{
    public class TicketEditModel
    {
        public int TicketId { get; set; }
        public int AirplaneId { get; set; }
        public Airplane Airplane { get; set; }
        public Passenger Passenger { get; set; }
        public int PassengerId { get; set; }
        public Trip Trip { get; set; }
        public int TripId { get; set; }
        public int SeatNo { get; set; }
    }
}
