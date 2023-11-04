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
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder
                .Entity<City>()
                .HasData(
               new City() { CityId = 1, CityName = "İstanbul" },
               new City() { CityId = 2, CityName = "Kocaeli" },
               new City() { CityId = 3, CityName = "Düzce" },
               new City() { CityId = 4, CityName = "Samsun" },
               new City() { CityId = 5, CityName = "Ordu" },
               new City() { CityId = 6, CityName = "Antalya" },
               new City() { CityId = 7, CityName = "Afyon" },
               new City() { CityId = 8, CityName = "Kütahya" },
               new City() { CityId = 9, CityName = "Rize" },
               new City() { CityId = 10, CityName = "Aydin" }

                );
            modelBuilder
                .Entity<Airplane>()
                .HasData(
                new Airplane() { AirplaneId = 1, SeatCapacity = 40 },
                new Airplane() { AirplaneId = 2, SeatCapacity = 40 },
                new Airplane() { AirplaneId = 3, SeatCapacity = 40 },
                new Airplane() { AirplaneId = 4, SeatCapacity = 40 },
                new Airplane() { AirplaneId = 5, SeatCapacity = 40 },
                new Airplane() { AirplaneId = 6, SeatCapacity = 40 }
                );
            modelBuilder
                .Entity<Trip>()
                .HasData(
                new Trip() { TripId = 1, TripDate = new DateTime(2023, 12, 25), FromWhereId = 1, ToWhereId = 5, Price = 429, AirplaneId = 1 },
                new Trip() { TripId = 2, TripDate = new DateTime(2023, 12, 25), FromWhereId = 1, ToWhereId = 2, Price = 129, AirplaneId = 1 },
                new Trip() { TripId = 3, TripDate = new DateTime(2023, 12, 25), FromWhereId = 1, ToWhereId = 3, Price = 189, AirplaneId = 1 },
                new Trip() { TripId = 4, TripDate = new DateTime(2023, 12, 25), FromWhereId = 1, ToWhereId = 4, Price = 399, AirplaneId = 1 },
                new Trip() { TripId = 5, TripDate = new DateTime(2023, 12, 25), FromWhereId = 2, ToWhereId = 3, Price = 149, AirplaneId = 1 },
                new Trip() { TripId = 6, TripDate = new DateTime(2023, 12, 25), FromWhereId = 2, ToWhereId = 4, Price = 429, AirplaneId = 1 },
                new Trip() { TripId = 7, TripDate = new DateTime(2023, 12, 25), FromWhereId = 2, ToWhereId = 5, Price = 469, AirplaneId = 1 },
                new Trip() { TripId = 8, TripDate = new DateTime(2023, 12, 25), FromWhereId = 3, ToWhereId = 4, Price = 419, AirplaneId = 1 },
                new Trip() { TripId = 9, TripDate = new DateTime(2023, 12, 25), FromWhereId = 3, ToWhereId = 5, Price = 449, AirplaneId = 1 },
                new Trip() { TripId = 10, TripDate = new DateTime(2023, 12, 25), FromWhereId = 4, ToWhereId = 5, Price = 119, AirplaneId = 1 },
                new Trip() { TripId = 11, TripDate = new DateTime(2023, 12, 25), FromWhereId = 6, ToWhereId = 1, Price = 469, AirplaneId = 1 },
                new Trip() { TripId = 12, TripDate = new DateTime(2023, 12, 25), FromWhereId = 6, ToWhereId = 7, Price = 169, AirplaneId = 1 },
                new Trip() { TripId = 13, TripDate = new DateTime(2023, 12, 25), FromWhereId = 6, ToWhereId = 8, Price = 239, AirplaneId = 1 },
                new Trip() { TripId = 14, TripDate = new DateTime(2023, 12, 25), FromWhereId = 6, ToWhereId = 2, Price = 399, AirplaneId = 1 },
                new Trip() { TripId = 15, TripDate = new DateTime(2023, 12, 25), FromWhereId = 7, ToWhereId = 8, Price = 449, AirplaneId = 1 },
                new Trip() { TripId = 16, TripDate = new DateTime(2023, 12, 25), FromWhereId = 7, ToWhereId = 2, Price = 149, AirplaneId = 1 },
                new Trip() { TripId = 17, TripDate = new DateTime(2023, 12, 25), FromWhereId = 7, ToWhereId = 1, Price = 129, AirplaneId = 1 },
                new Trip() { TripId = 18, TripDate = new DateTime(2023, 12, 25), FromWhereId = 8, ToWhereId = 2, Price = 449, AirplaneId = 1 },
                new Trip() { TripId = 19, TripDate = new DateTime(2023, 12, 25), FromWhereId = 8, ToWhereId = 1, Price = 449, AirplaneId = 1 },
                new Trip() { TripId = 20, TripDate = new DateTime(2023, 12, 25), FromWhereId = 2, ToWhereId = 1, Price = 149, AirplaneId = 1 },
                new Trip() { TripId = 21, TripDate = new DateTime(2023, 12, 25), FromWhereId = 5, ToWhereId = 1, Price = 399, AirplaneId = 1 },
                new Trip() { TripId = 22, TripDate = new DateTime(2023, 12, 25), FromWhereId = 5, ToWhereId = 4, Price = 129, AirplaneId = 1 },
                new Trip() { TripId = 23, TripDate = new DateTime(2023, 12, 25), FromWhereId = 5, ToWhereId = 3, Price = 239, AirplaneId = 1 },
                new Trip() { TripId = 24, TripDate = new DateTime(2023, 12, 25), FromWhereId = 5, ToWhereId = 2, Price = 239, AirplaneId = 1 },
                new Trip() { TripId = 25, TripDate = new DateTime(2023, 12, 25), FromWhereId = 4, ToWhereId = 3, Price = 239, AirplaneId = 1 },
                new Trip() { TripId = 26, TripDate = new DateTime(2023, 12, 25), FromWhereId = 4, ToWhereId = 2, Price = 399, AirplaneId = 1 },
                new Trip() { TripId = 27, TripDate = new DateTime(2023, 12, 25), FromWhereId = 4, ToWhereId = 1, Price = 449, AirplaneId = 1 },
                new Trip() { TripId = 28, TripDate = new DateTime(2023, 12, 25), FromWhereId = 3, ToWhereId = 2, Price = 449, AirplaneId = 1 },
                new Trip() { TripId = 29, TripDate = new DateTime(2023, 12, 25), FromWhereId = 3, ToWhereId = 1, Price = 239, AirplaneId = 1 },
                new Trip() { TripId = 30, TripDate = new DateTime(2023, 12, 25), FromWhereId = 2, ToWhereId = 1, Price = 129, AirplaneId = 1 },
                new Trip() { TripId = 31, TripDate = new DateTime(2023, 12, 25), FromWhereId = 1, ToWhereId = 6, Price = 449, AirplaneId = 1 },
                new Trip() { TripId = 32, TripDate = new DateTime(2023, 12, 25), FromWhereId = 1, ToWhereId = 2, Price = 419, AirplaneId = 1 },
                new Trip() { TripId = 33, TripDate = new DateTime(2023, 12, 25), FromWhereId = 1, ToWhereId = 8, Price = 239, AirplaneId = 1 },
                new Trip() { TripId = 34, TripDate = new DateTime(2023, 12, 25), FromWhereId = 1, ToWhereId = 7, Price = 419, AirplaneId = 1 },
                new Trip() { TripId = 35, TripDate = new DateTime(2023, 12, 25), FromWhereId = 2, ToWhereId = 8, Price = 419, AirplaneId = 1 },
                new Trip() { TripId = 36, TripDate = new DateTime(2023, 12, 25), FromWhereId = 2, ToWhereId = 7, Price = 149, AirplaneId = 1 },
                new Trip() { TripId = 37, TripDate = new DateTime(2023, 12, 25), FromWhereId = 2, ToWhereId = 6, Price = 419, AirplaneId = 1 },
                new Trip() { TripId = 38, TripDate = new DateTime(2023, 12, 25), FromWhereId = 8, ToWhereId = 7, Price = 239, AirplaneId = 1 },
                new Trip() { TripId = 39, TripDate = new DateTime(2023, 12, 25), FromWhereId = 8, ToWhereId = 6, Price = 449, AirplaneId = 1 },
                new Trip() { TripId = 40, TripDate = new DateTime(2023, 12, 25), FromWhereId = 7, ToWhereId = 6, Price = 399, AirplaneId = 1 }



                );



            modelBuilder
                .Entity<Passenger>()
                .HasData(
                new Passenger() { PassengerId = 1, FirstName = "Buse", LastName = "Karafazlioglu", Email = "busekarafazli@gmail.com", PhoneNumber = "01234567891" },
                new Passenger() { PassengerId = 2, FirstName = "Mete", LastName = "Ucar", Email = "meteucar@gmail.com", PhoneNumber = "01234567892" }

                );
            modelBuilder
                .Entity<Ticket>()
                .HasData(
                new Ticket() { TicketId = 1, PassengerId = 1, AirplaneId = 1, TripId = 1, SeatNo = 1 }
                );

        }
}
}
