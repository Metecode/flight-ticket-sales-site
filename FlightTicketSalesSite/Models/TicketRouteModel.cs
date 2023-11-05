using System.ComponentModel.DataAnnotations;
using FlightTicketSalesSite.Entity;

namespace FlightTicketSalesSite.Models
{
    public class TicketRouteModel
    {
        public List<City> Cities { get; set; }
        [Required(ErrorMessage = "Please Select Departure City.")]

        public int FromWhereId { get; set; }
        [Required(ErrorMessage = "Please Select Arrival City.")]

        public int ToWhereId { get; set; }
        [Required(ErrorMessage = "Please Select a Date.")]

        public DateTime TripDate { get; set; }
    }
}
