using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using FlightTicketSalesSite.Entity;

namespace FlightTicketSalesSite.Data.Concrete
{
    public class AirplaneContext : DbContext
    {
        public AirplaneContext(DbContextOptions options) : base(options)
        {

        }
        
        public DbSet<City> Cities { get; set; }
        public DbSet<Ticket> Tickets { get; set; }
        public DbSet<Passenger> Passengers { get; set; }
        public DbSet<Airplane> Airplanes { get; set; }
        public DbSet<Trip> Trips { get; set; }
    }
}
