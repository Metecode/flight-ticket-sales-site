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
    [Migration("20231102212748_Initial")]
    partial class Initial
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

                    b.ToTable("Buses");
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