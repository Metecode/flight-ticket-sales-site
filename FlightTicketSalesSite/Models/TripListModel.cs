using FlightTicketSalesSite.Entity;

namespace FlightTicketSalesSite.Models
{
    public class TripListModel
    {
        public int TripId { get; set; }
        public int FromWhereId { get; set; }
        public int ToWhereId { get; set; }
        public City FromWhere { get; set; }
        public City ToWhere { get; set; }
        public decimal Price { get; set; }
        public DateTime TripTime { get; set; }
        public Airplane Airplane { get; set; }
        public int AirplaneId { get; set; }
    }
}
