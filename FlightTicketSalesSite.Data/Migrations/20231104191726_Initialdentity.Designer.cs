﻿// <auto-generated />
using System;
using FlightTicketSalesSite.Data.Concrete;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

#nullable disable

namespace FlightTicketSalesSite.Data.Migrations
{
    [DbContext(typeof(AirplaneContext))]
    [Migration("20231104191726_Initialdentity")]
    partial class Initialdentity
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder.HasAnnotation("ProductVersion", "6.0.22");

            modelBuilder.Entity("FlightTicketSalesSite.Entity.Airplane", b =>
                {
                    b.Property<int>("AirplaneId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("INTEGER");

                    b.Property<int>("SeatCapacity")
                        .HasColumnType("INTEGER");

                    b.HasKey("AirplaneId");

                    b.ToTable("Airplanes");

                    b.HasData(
                        new
                        {
                            AirplaneId = 1,
                            SeatCapacity = 40
                        },
                        new
                        {
                            AirplaneId = 2,
                            SeatCapacity = 40
                        },
                        new
                        {
                            AirplaneId = 3,
                            SeatCapacity = 40
                        },
                        new
                        {
                            AirplaneId = 4,
                            SeatCapacity = 40
                        },
                        new
                        {
                            AirplaneId = 5,
                            SeatCapacity = 40
                        },
                        new
                        {
                            AirplaneId = 6,
                            SeatCapacity = 40
                        });
                });

            modelBuilder.Entity("FlightTicketSalesSite.Entity.City", b =>
                {
                    b.Property<int>("CityId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("INTEGER");

                    b.Property<string>("CityName")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.HasKey("CityId");

                    b.ToTable("Cities");

                    b.HasData(
                        new
                        {
                            CityId = 1,
                            CityName = "İstanbul"
                        },
                        new
                        {
                            CityId = 2,
                            CityName = "Kocaeli"
                        },
                        new
                        {
                            CityId = 3,
                            CityName = "Düzce"
                        },
                        new
                        {
                            CityId = 4,
                            CityName = "Samsun"
                        },
                        new
                        {
                            CityId = 5,
                            CityName = "Ordu"
                        },
                        new
                        {
                            CityId = 6,
                            CityName = "Antalya"
                        },
                        new
                        {
                            CityId = 7,
                            CityName = "Afyon"
                        },
                        new
                        {
                            CityId = 8,
                            CityName = "Kütahya"
                        },
                        new
                        {
                            CityId = 9,
                            CityName = "Rize"
                        },
                        new
                        {
                            CityId = 10,
                            CityName = "Aydin"
                        });
                });

            modelBuilder.Entity("FlightTicketSalesSite.Entity.Passenger", b =>
                {
                    b.Property<int>("PassengerId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("INTEGER");

                    b.Property<string>("Email")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.Property<string>("FirstName")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.Property<string>("LastName")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.Property<string>("PhoneNumber")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.HasKey("PassengerId");

                    b.ToTable("Passengers");

                    b.HasData(
                        new
                        {
                            PassengerId = 1,
                            Email = "busekarafazli@gmail.com",
                            FirstName = "Buse",
                            LastName = "Karafazlioglu",
                            PhoneNumber = "01234567891"
                        },
                        new
                        {
                            PassengerId = 2,
                            Email = "meteucar@gmail.com",
                            FirstName = "Mete",
                            LastName = "Ucar",
                            PhoneNumber = "01234567892"
                        });
                });

            modelBuilder.Entity("FlightTicketSalesSite.Entity.Ticket", b =>
                {
                    b.Property<int>("TicketId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("INTEGER");

                    b.Property<int>("AirplaneId")
                        .HasColumnType("INTEGER");

                    b.Property<int>("PassengerId")
                        .HasColumnType("INTEGER");

                    b.Property<int>("SeatNo")
                        .HasColumnType("INTEGER");

                    b.Property<int>("TripId")
                        .HasColumnType("INTEGER");

                    b.HasKey("TicketId");

                    b.HasIndex("AirplaneId");

                    b.HasIndex("PassengerId");

                    b.HasIndex("TripId");

                    b.ToTable("Tickets");

                    b.HasData(
                        new
                        {
                            TicketId = 1,
                            AirplaneId = 1,
                            PassengerId = 1,
                            SeatNo = 1,
                            TripId = 1
                        });
                });

            modelBuilder.Entity("FlightTicketSalesSite.Entity.Trip", b =>
                {
                    b.Property<int>("TripId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("INTEGER");

                    b.Property<int>("AirplaneId")
                        .HasColumnType("INTEGER");

                    b.Property<int>("FromWhereId")
                        .HasColumnType("INTEGER");

                    b.Property<decimal>("Price")
                        .HasColumnType("TEXT");

                    b.Property<int>("ToWhereId")
                        .HasColumnType("INTEGER");

                    b.Property<DateTime>("TripDate")
                        .HasColumnType("TEXT");

                    b.Property<DateTime>("TripTime")
                        .HasColumnType("TEXT");

                    b.HasKey("TripId");

                    b.HasIndex("AirplaneId");

                    b.HasIndex("FromWhereId");

                    b.HasIndex("ToWhereId");

                    b.ToTable("Trips");

                    b.HasData(
                        new
                        {
                            TripId = 1,
                            AirplaneId = 1,
                            FromWhereId = 1,
                            Price = 429m,
                            ToWhereId = 5,
                            TripDate = new DateTime(2023, 12, 25, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            TripTime = new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified)
                        },
                        new
                        {
                            TripId = 2,
                            AirplaneId = 1,
                            FromWhereId = 1,
                            Price = 129m,
                            ToWhereId = 2,
                            TripDate = new DateTime(2023, 12, 25, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            TripTime = new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified)
                        },
                        new
                        {
                            TripId = 3,
                            AirplaneId = 1,
                            FromWhereId = 1,
                            Price = 189m,
                            ToWhereId = 3,
                            TripDate = new DateTime(2023, 12, 25, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            TripTime = new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified)
                        },
                        new
                        {
                            TripId = 4,
                            AirplaneId = 1,
                            FromWhereId = 1,
                            Price = 399m,
                            ToWhereId = 4,
                            TripDate = new DateTime(2023, 12, 25, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            TripTime = new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified)
                        },
                        new
                        {
                            TripId = 5,
                            AirplaneId = 1,
                            FromWhereId = 2,
                            Price = 149m,
                            ToWhereId = 3,
                            TripDate = new DateTime(2023, 12, 25, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            TripTime = new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified)
                        },
                        new
                        {
                            TripId = 6,
                            AirplaneId = 1,
                            FromWhereId = 2,
                            Price = 429m,
                            ToWhereId = 4,
                            TripDate = new DateTime(2023, 12, 25, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            TripTime = new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified)
                        },
                        new
                        {
                            TripId = 7,
                            AirplaneId = 1,
                            FromWhereId = 2,
                            Price = 469m,
                            ToWhereId = 5,
                            TripDate = new DateTime(2023, 12, 25, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            TripTime = new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified)
                        },
                        new
                        {
                            TripId = 8,
                            AirplaneId = 1,
                            FromWhereId = 3,
                            Price = 419m,
                            ToWhereId = 4,
                            TripDate = new DateTime(2023, 12, 25, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            TripTime = new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified)
                        },
                        new
                        {
                            TripId = 9,
                            AirplaneId = 1,
                            FromWhereId = 3,
                            Price = 449m,
                            ToWhereId = 5,
                            TripDate = new DateTime(2023, 12, 25, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            TripTime = new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified)
                        },
                        new
                        {
                            TripId = 10,
                            AirplaneId = 1,
                            FromWhereId = 4,
                            Price = 119m,
                            ToWhereId = 5,
                            TripDate = new DateTime(2023, 12, 25, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            TripTime = new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified)
                        },
                        new
                        {
                            TripId = 11,
                            AirplaneId = 1,
                            FromWhereId = 6,
                            Price = 469m,
                            ToWhereId = 1,
                            TripDate = new DateTime(2023, 12, 25, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            TripTime = new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified)
                        },
                        new
                        {
                            TripId = 12,
                            AirplaneId = 1,
                            FromWhereId = 6,
                            Price = 169m,
                            ToWhereId = 7,
                            TripDate = new DateTime(2023, 12, 25, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            TripTime = new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified)
                        },
                        new
                        {
                            TripId = 13,
                            AirplaneId = 1,
                            FromWhereId = 6,
                            Price = 239m,
                            ToWhereId = 8,
                            TripDate = new DateTime(2023, 12, 25, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            TripTime = new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified)
                        },
                        new
                        {
                            TripId = 14,
                            AirplaneId = 1,
                            FromWhereId = 6,
                            Price = 399m,
                            ToWhereId = 2,
                            TripDate = new DateTime(2023, 12, 25, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            TripTime = new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified)
                        },
                        new
                        {
                            TripId = 15,
                            AirplaneId = 1,
                            FromWhereId = 7,
                            Price = 449m,
                            ToWhereId = 8,
                            TripDate = new DateTime(2023, 12, 25, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            TripTime = new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified)
                        },
                        new
                        {
                            TripId = 16,
                            AirplaneId = 1,
                            FromWhereId = 7,
                            Price = 149m,
                            ToWhereId = 2,
                            TripDate = new DateTime(2023, 12, 25, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            TripTime = new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified)
                        },
                        new
                        {
                            TripId = 17,
                            AirplaneId = 1,
                            FromWhereId = 7,
                            Price = 129m,
                            ToWhereId = 1,
                            TripDate = new DateTime(2023, 12, 25, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            TripTime = new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified)
                        },
                        new
                        {
                            TripId = 18,
                            AirplaneId = 1,
                            FromWhereId = 8,
                            Price = 449m,
                            ToWhereId = 2,
                            TripDate = new DateTime(2023, 12, 25, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            TripTime = new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified)
                        },
                        new
                        {
                            TripId = 19,
                            AirplaneId = 1,
                            FromWhereId = 8,
                            Price = 449m,
                            ToWhereId = 1,
                            TripDate = new DateTime(2023, 12, 25, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            TripTime = new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified)
                        },
                        new
                        {
                            TripId = 20,
                            AirplaneId = 1,
                            FromWhereId = 2,
                            Price = 149m,
                            ToWhereId = 1,
                            TripDate = new DateTime(2023, 12, 25, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            TripTime = new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified)
                        },
                        new
                        {
                            TripId = 21,
                            AirplaneId = 1,
                            FromWhereId = 5,
                            Price = 399m,
                            ToWhereId = 1,
                            TripDate = new DateTime(2023, 12, 25, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            TripTime = new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified)
                        },
                        new
                        {
                            TripId = 22,
                            AirplaneId = 1,
                            FromWhereId = 5,
                            Price = 129m,
                            ToWhereId = 4,
                            TripDate = new DateTime(2023, 12, 25, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            TripTime = new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified)
                        },
                        new
                        {
                            TripId = 23,
                            AirplaneId = 1,
                            FromWhereId = 5,
                            Price = 239m,
                            ToWhereId = 3,
                            TripDate = new DateTime(2023, 12, 25, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            TripTime = new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified)
                        },
                        new
                        {
                            TripId = 24,
                            AirplaneId = 1,
                            FromWhereId = 5,
                            Price = 239m,
                            ToWhereId = 2,
                            TripDate = new DateTime(2023, 12, 25, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            TripTime = new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified)
                        },
                        new
                        {
                            TripId = 25,
                            AirplaneId = 1,
                            FromWhereId = 4,
                            Price = 239m,
                            ToWhereId = 3,
                            TripDate = new DateTime(2023, 12, 25, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            TripTime = new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified)
                        },
                        new
                        {
                            TripId = 26,
                            AirplaneId = 1,
                            FromWhereId = 4,
                            Price = 399m,
                            ToWhereId = 2,
                            TripDate = new DateTime(2023, 12, 25, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            TripTime = new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified)
                        },
                        new
                        {
                            TripId = 27,
                            AirplaneId = 1,
                            FromWhereId = 4,
                            Price = 449m,
                            ToWhereId = 1,
                            TripDate = new DateTime(2023, 12, 25, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            TripTime = new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified)
                        },
                        new
                        {
                            TripId = 28,
                            AirplaneId = 1,
                            FromWhereId = 3,
                            Price = 449m,
                            ToWhereId = 2,
                            TripDate = new DateTime(2023, 12, 25, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            TripTime = new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified)
                        },
                        new
                        {
                            TripId = 29,
                            AirplaneId = 1,
                            FromWhereId = 3,
                            Price = 239m,
                            ToWhereId = 1,
                            TripDate = new DateTime(2023, 12, 25, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            TripTime = new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified)
                        },
                        new
                        {
                            TripId = 30,
                            AirplaneId = 1,
                            FromWhereId = 2,
                            Price = 129m,
                            ToWhereId = 1,
                            TripDate = new DateTime(2023, 12, 25, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            TripTime = new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified)
                        },
                        new
                        {
                            TripId = 31,
                            AirplaneId = 1,
                            FromWhereId = 1,
                            Price = 449m,
                            ToWhereId = 6,
                            TripDate = new DateTime(2023, 12, 25, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            TripTime = new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified)
                        },
                        new
                        {
                            TripId = 32,
                            AirplaneId = 1,
                            FromWhereId = 1,
                            Price = 419m,
                            ToWhereId = 2,
                            TripDate = new DateTime(2023, 12, 25, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            TripTime = new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified)
                        },
                        new
                        {
                            TripId = 33,
                            AirplaneId = 1,
                            FromWhereId = 1,
                            Price = 239m,
                            ToWhereId = 8,
                            TripDate = new DateTime(2023, 12, 25, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            TripTime = new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified)
                        },
                        new
                        {
                            TripId = 34,
                            AirplaneId = 1,
                            FromWhereId = 1,
                            Price = 419m,
                            ToWhereId = 7,
                            TripDate = new DateTime(2023, 12, 25, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            TripTime = new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified)
                        },
                        new
                        {
                            TripId = 35,
                            AirplaneId = 1,
                            FromWhereId = 2,
                            Price = 419m,
                            ToWhereId = 8,
                            TripDate = new DateTime(2023, 12, 25, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            TripTime = new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified)
                        },
                        new
                        {
                            TripId = 36,
                            AirplaneId = 1,
                            FromWhereId = 2,
                            Price = 149m,
                            ToWhereId = 7,
                            TripDate = new DateTime(2023, 12, 25, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            TripTime = new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified)
                        },
                        new
                        {
                            TripId = 37,
                            AirplaneId = 1,
                            FromWhereId = 2,
                            Price = 419m,
                            ToWhereId = 6,
                            TripDate = new DateTime(2023, 12, 25, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            TripTime = new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified)
                        },
                        new
                        {
                            TripId = 38,
                            AirplaneId = 1,
                            FromWhereId = 8,
                            Price = 239m,
                            ToWhereId = 7,
                            TripDate = new DateTime(2023, 12, 25, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            TripTime = new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified)
                        },
                        new
                        {
                            TripId = 39,
                            AirplaneId = 1,
                            FromWhereId = 8,
                            Price = 449m,
                            ToWhereId = 6,
                            TripDate = new DateTime(2023, 12, 25, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            TripTime = new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified)
                        },
                        new
                        {
                            TripId = 40,
                            AirplaneId = 1,
                            FromWhereId = 7,
                            Price = 399m,
                            ToWhereId = 6,
                            TripDate = new DateTime(2023, 12, 25, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            TripTime = new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified)
                        });
                });

            modelBuilder.Entity("FlightTicketSalesSite.Entity.Ticket", b =>
                {
                    b.HasOne("FlightTicketSalesSite.Entity.Airplane", "Airplane")
                        .WithMany("Tickets")
                        .HasForeignKey("AirplaneId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("FlightTicketSalesSite.Entity.Passenger", "Passenger")
                        .WithMany("Tickets")
                        .HasForeignKey("PassengerId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("FlightTicketSalesSite.Entity.Trip", "Trip")
                        .WithMany("Tickets")
                        .HasForeignKey("TripId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Airplane");

                    b.Navigation("Passenger");

                    b.Navigation("Trip");
                });

            modelBuilder.Entity("FlightTicketSalesSite.Entity.Trip", b =>
                {
                    b.HasOne("FlightTicketSalesSite.Entity.Airplane", "Airplane")
                        .WithMany("Trips")
                        .HasForeignKey("AirplaneId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("FlightTicketSalesSite.Entity.City", "FromWhere")
                        .WithMany()
                        .HasForeignKey("FromWhereId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("FlightTicketSalesSite.Entity.City", "ToWhere")
                        .WithMany()
                        .HasForeignKey("ToWhereId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Airplane");

                    b.Navigation("FromWhere");

                    b.Navigation("ToWhere");
                });

            modelBuilder.Entity("FlightTicketSalesSite.Entity.Airplane", b =>
                {
                    b.Navigation("Tickets");

                    b.Navigation("Trips");
                });

            modelBuilder.Entity("FlightTicketSalesSite.Entity.Passenger", b =>
                {
                    b.Navigation("Tickets");
                });

            modelBuilder.Entity("FlightTicketSalesSite.Entity.Trip", b =>
                {
                    b.Navigation("Tickets");
                });
#pragma warning restore 612, 618
        }
    }
}
