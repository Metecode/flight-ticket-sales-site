﻿using System.Net.Sockets;
using FlightTicketSalesSite.Entity;

namespace FlightTicketSalesSite.Models
{
    public class TicketDetailsModel
    {
        public string? FirstName { get; set; }
        public string? LastName { get; set; }
        public string? PhoneNumber { get; set; }
        public string? Email { get; set; }
        public int SeatNo { get; set; }
        public DateTime TripDate { get; set; }
        public DateTime TripTime { get; set; }
        public Passenger? Passenger { get; set; }
        public Ticket? Ticket { get; set; }
        public City? FromWhere { get; set; }
        public City? ToWhere { get; set; }
        public int FromWhereId { get; set; }
        public int ToWhereId { get; set; }
        public List<City>? Cities { get; set; }

        public int TripId { get; set; }
        public Trip? Trip { get; set; }
        public Airplane? Airplane { get; set; }
        public int AirplaneId { get; set; }
    }
}
