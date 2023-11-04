using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace FlightTicketSalesSite.Data.Migrations
{
    public partial class Initialdentity : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "Airplanes",
                columns: new[] { "AirplaneId", "SeatCapacity" },
                values: new object[] { 1, 40 });

            migrationBuilder.InsertData(
                table: "Airplanes",
                columns: new[] { "AirplaneId", "SeatCapacity" },
                values: new object[] { 2, 40 });

            migrationBuilder.InsertData(
                table: "Airplanes",
                columns: new[] { "AirplaneId", "SeatCapacity" },
                values: new object[] { 3, 40 });

            migrationBuilder.InsertData(
                table: "Airplanes",
                columns: new[] { "AirplaneId", "SeatCapacity" },
                values: new object[] { 4, 40 });

            migrationBuilder.InsertData(
                table: "Airplanes",
                columns: new[] { "AirplaneId", "SeatCapacity" },
                values: new object[] { 5, 40 });

            migrationBuilder.InsertData(
                table: "Airplanes",
                columns: new[] { "AirplaneId", "SeatCapacity" },
                values: new object[] { 6, 40 });

            migrationBuilder.InsertData(
                table: "Cities",
                columns: new[] { "CityId", "CityName" },
                values: new object[] { 1, "İstanbul" });

            migrationBuilder.InsertData(
                table: "Cities",
                columns: new[] { "CityId", "CityName" },
                values: new object[] { 2, "Kocaeli" });

            migrationBuilder.InsertData(
                table: "Cities",
                columns: new[] { "CityId", "CityName" },
                values: new object[] { 3, "Düzce" });

            migrationBuilder.InsertData(
                table: "Cities",
                columns: new[] { "CityId", "CityName" },
                values: new object[] { 4, "Samsun" });

            migrationBuilder.InsertData(
                table: "Cities",
                columns: new[] { "CityId", "CityName" },
                values: new object[] { 5, "Ordu" });

            migrationBuilder.InsertData(
                table: "Cities",
                columns: new[] { "CityId", "CityName" },
                values: new object[] { 6, "Antalya" });

            migrationBuilder.InsertData(
                table: "Cities",
                columns: new[] { "CityId", "CityName" },
                values: new object[] { 7, "Afyon" });

            migrationBuilder.InsertData(
                table: "Cities",
                columns: new[] { "CityId", "CityName" },
                values: new object[] { 8, "Kütahya" });

            migrationBuilder.InsertData(
                table: "Cities",
                columns: new[] { "CityId", "CityName" },
                values: new object[] { 9, "Rize" });

            migrationBuilder.InsertData(
                table: "Cities",
                columns: new[] { "CityId", "CityName" },
                values: new object[] { 10, "Aydin" });

            migrationBuilder.InsertData(
                table: "Passengers",
                columns: new[] { "PassengerId", "Email", "FirstName", "LastName", "PhoneNumber" },
                values: new object[] { 1, "busekarafazli@gmail.com", "Buse", "Karafazlioglu", "01234567891" });

            migrationBuilder.InsertData(
                table: "Passengers",
                columns: new[] { "PassengerId", "Email", "FirstName", "LastName", "PhoneNumber" },
                values: new object[] { 2, "meteucar@gmail.com", "Mete", "Ucar", "01234567892" });

            migrationBuilder.InsertData(
                table: "Trips",
                columns: new[] { "TripId", "AirplaneId", "FromWhereId", "Price", "ToWhereId", "TripDate", "TripTime" },
                values: new object[] { 1, 1, 1, 429m, 5, new DateTime(2023, 12, 25, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.InsertData(
                table: "Trips",
                columns: new[] { "TripId", "AirplaneId", "FromWhereId", "Price", "ToWhereId", "TripDate", "TripTime" },
                values: new object[] { 2, 1, 1, 129m, 2, new DateTime(2023, 12, 25, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.InsertData(
                table: "Trips",
                columns: new[] { "TripId", "AirplaneId", "FromWhereId", "Price", "ToWhereId", "TripDate", "TripTime" },
                values: new object[] { 3, 1, 1, 189m, 3, new DateTime(2023, 12, 25, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.InsertData(
                table: "Trips",
                columns: new[] { "TripId", "AirplaneId", "FromWhereId", "Price", "ToWhereId", "TripDate", "TripTime" },
                values: new object[] { 4, 1, 1, 399m, 4, new DateTime(2023, 12, 25, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.InsertData(
                table: "Trips",
                columns: new[] { "TripId", "AirplaneId", "FromWhereId", "Price", "ToWhereId", "TripDate", "TripTime" },
                values: new object[] { 5, 1, 2, 149m, 3, new DateTime(2023, 12, 25, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.InsertData(
                table: "Trips",
                columns: new[] { "TripId", "AirplaneId", "FromWhereId", "Price", "ToWhereId", "TripDate", "TripTime" },
                values: new object[] { 6, 1, 2, 429m, 4, new DateTime(2023, 12, 25, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.InsertData(
                table: "Trips",
                columns: new[] { "TripId", "AirplaneId", "FromWhereId", "Price", "ToWhereId", "TripDate", "TripTime" },
                values: new object[] { 7, 1, 2, 469m, 5, new DateTime(2023, 12, 25, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.InsertData(
                table: "Trips",
                columns: new[] { "TripId", "AirplaneId", "FromWhereId", "Price", "ToWhereId", "TripDate", "TripTime" },
                values: new object[] { 8, 1, 3, 419m, 4, new DateTime(2023, 12, 25, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.InsertData(
                table: "Trips",
                columns: new[] { "TripId", "AirplaneId", "FromWhereId", "Price", "ToWhereId", "TripDate", "TripTime" },
                values: new object[] { 9, 1, 3, 449m, 5, new DateTime(2023, 12, 25, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.InsertData(
                table: "Trips",
                columns: new[] { "TripId", "AirplaneId", "FromWhereId", "Price", "ToWhereId", "TripDate", "TripTime" },
                values: new object[] { 10, 1, 4, 119m, 5, new DateTime(2023, 12, 25, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.InsertData(
                table: "Trips",
                columns: new[] { "TripId", "AirplaneId", "FromWhereId", "Price", "ToWhereId", "TripDate", "TripTime" },
                values: new object[] { 11, 1, 6, 469m, 1, new DateTime(2023, 12, 25, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.InsertData(
                table: "Trips",
                columns: new[] { "TripId", "AirplaneId", "FromWhereId", "Price", "ToWhereId", "TripDate", "TripTime" },
                values: new object[] { 12, 1, 6, 169m, 7, new DateTime(2023, 12, 25, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.InsertData(
                table: "Trips",
                columns: new[] { "TripId", "AirplaneId", "FromWhereId", "Price", "ToWhereId", "TripDate", "TripTime" },
                values: new object[] { 13, 1, 6, 239m, 8, new DateTime(2023, 12, 25, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.InsertData(
                table: "Trips",
                columns: new[] { "TripId", "AirplaneId", "FromWhereId", "Price", "ToWhereId", "TripDate", "TripTime" },
                values: new object[] { 14, 1, 6, 399m, 2, new DateTime(2023, 12, 25, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.InsertData(
                table: "Trips",
                columns: new[] { "TripId", "AirplaneId", "FromWhereId", "Price", "ToWhereId", "TripDate", "TripTime" },
                values: new object[] { 15, 1, 7, 449m, 8, new DateTime(2023, 12, 25, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.InsertData(
                table: "Trips",
                columns: new[] { "TripId", "AirplaneId", "FromWhereId", "Price", "ToWhereId", "TripDate", "TripTime" },
                values: new object[] { 16, 1, 7, 149m, 2, new DateTime(2023, 12, 25, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.InsertData(
                table: "Trips",
                columns: new[] { "TripId", "AirplaneId", "FromWhereId", "Price", "ToWhereId", "TripDate", "TripTime" },
                values: new object[] { 17, 1, 7, 129m, 1, new DateTime(2023, 12, 25, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.InsertData(
                table: "Trips",
                columns: new[] { "TripId", "AirplaneId", "FromWhereId", "Price", "ToWhereId", "TripDate", "TripTime" },
                values: new object[] { 18, 1, 8, 449m, 2, new DateTime(2023, 12, 25, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.InsertData(
                table: "Trips",
                columns: new[] { "TripId", "AirplaneId", "FromWhereId", "Price", "ToWhereId", "TripDate", "TripTime" },
                values: new object[] { 19, 1, 8, 449m, 1, new DateTime(2023, 12, 25, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.InsertData(
                table: "Trips",
                columns: new[] { "TripId", "AirplaneId", "FromWhereId", "Price", "ToWhereId", "TripDate", "TripTime" },
                values: new object[] { 20, 1, 2, 149m, 1, new DateTime(2023, 12, 25, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.InsertData(
                table: "Trips",
                columns: new[] { "TripId", "AirplaneId", "FromWhereId", "Price", "ToWhereId", "TripDate", "TripTime" },
                values: new object[] { 21, 1, 5, 399m, 1, new DateTime(2023, 12, 25, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.InsertData(
                table: "Trips",
                columns: new[] { "TripId", "AirplaneId", "FromWhereId", "Price", "ToWhereId", "TripDate", "TripTime" },
                values: new object[] { 22, 1, 5, 129m, 4, new DateTime(2023, 12, 25, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.InsertData(
                table: "Trips",
                columns: new[] { "TripId", "AirplaneId", "FromWhereId", "Price", "ToWhereId", "TripDate", "TripTime" },
                values: new object[] { 23, 1, 5, 239m, 3, new DateTime(2023, 12, 25, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.InsertData(
                table: "Trips",
                columns: new[] { "TripId", "AirplaneId", "FromWhereId", "Price", "ToWhereId", "TripDate", "TripTime" },
                values: new object[] { 24, 1, 5, 239m, 2, new DateTime(2023, 12, 25, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.InsertData(
                table: "Trips",
                columns: new[] { "TripId", "AirplaneId", "FromWhereId", "Price", "ToWhereId", "TripDate", "TripTime" },
                values: new object[] { 25, 1, 4, 239m, 3, new DateTime(2023, 12, 25, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.InsertData(
                table: "Trips",
                columns: new[] { "TripId", "AirplaneId", "FromWhereId", "Price", "ToWhereId", "TripDate", "TripTime" },
                values: new object[] { 26, 1, 4, 399m, 2, new DateTime(2023, 12, 25, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.InsertData(
                table: "Trips",
                columns: new[] { "TripId", "AirplaneId", "FromWhereId", "Price", "ToWhereId", "TripDate", "TripTime" },
                values: new object[] { 27, 1, 4, 449m, 1, new DateTime(2023, 12, 25, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.InsertData(
                table: "Trips",
                columns: new[] { "TripId", "AirplaneId", "FromWhereId", "Price", "ToWhereId", "TripDate", "TripTime" },
                values: new object[] { 28, 1, 3, 449m, 2, new DateTime(2023, 12, 25, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.InsertData(
                table: "Trips",
                columns: new[] { "TripId", "AirplaneId", "FromWhereId", "Price", "ToWhereId", "TripDate", "TripTime" },
                values: new object[] { 29, 1, 3, 239m, 1, new DateTime(2023, 12, 25, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.InsertData(
                table: "Trips",
                columns: new[] { "TripId", "AirplaneId", "FromWhereId", "Price", "ToWhereId", "TripDate", "TripTime" },
                values: new object[] { 30, 1, 2, 129m, 1, new DateTime(2023, 12, 25, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.InsertData(
                table: "Trips",
                columns: new[] { "TripId", "AirplaneId", "FromWhereId", "Price", "ToWhereId", "TripDate", "TripTime" },
                values: new object[] { 31, 1, 1, 449m, 6, new DateTime(2023, 12, 25, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.InsertData(
                table: "Trips",
                columns: new[] { "TripId", "AirplaneId", "FromWhereId", "Price", "ToWhereId", "TripDate", "TripTime" },
                values: new object[] { 32, 1, 1, 419m, 2, new DateTime(2023, 12, 25, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.InsertData(
                table: "Trips",
                columns: new[] { "TripId", "AirplaneId", "FromWhereId", "Price", "ToWhereId", "TripDate", "TripTime" },
                values: new object[] { 33, 1, 1, 239m, 8, new DateTime(2023, 12, 25, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.InsertData(
                table: "Trips",
                columns: new[] { "TripId", "AirplaneId", "FromWhereId", "Price", "ToWhereId", "TripDate", "TripTime" },
                values: new object[] { 34, 1, 1, 419m, 7, new DateTime(2023, 12, 25, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.InsertData(
                table: "Trips",
                columns: new[] { "TripId", "AirplaneId", "FromWhereId", "Price", "ToWhereId", "TripDate", "TripTime" },
                values: new object[] { 35, 1, 2, 419m, 8, new DateTime(2023, 12, 25, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.InsertData(
                table: "Trips",
                columns: new[] { "TripId", "AirplaneId", "FromWhereId", "Price", "ToWhereId", "TripDate", "TripTime" },
                values: new object[] { 36, 1, 2, 149m, 7, new DateTime(2023, 12, 25, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.InsertData(
                table: "Trips",
                columns: new[] { "TripId", "AirplaneId", "FromWhereId", "Price", "ToWhereId", "TripDate", "TripTime" },
                values: new object[] { 37, 1, 2, 419m, 6, new DateTime(2023, 12, 25, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.InsertData(
                table: "Trips",
                columns: new[] { "TripId", "AirplaneId", "FromWhereId", "Price", "ToWhereId", "TripDate", "TripTime" },
                values: new object[] { 38, 1, 8, 239m, 7, new DateTime(2023, 12, 25, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.InsertData(
                table: "Trips",
                columns: new[] { "TripId", "AirplaneId", "FromWhereId", "Price", "ToWhereId", "TripDate", "TripTime" },
                values: new object[] { 39, 1, 8, 449m, 6, new DateTime(2023, 12, 25, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.InsertData(
                table: "Trips",
                columns: new[] { "TripId", "AirplaneId", "FromWhereId", "Price", "ToWhereId", "TripDate", "TripTime" },
                values: new object[] { 40, 1, 7, 399m, 6, new DateTime(2023, 12, 25, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.InsertData(
                table: "Tickets",
                columns: new[] { "TicketId", "AirplaneId", "PassengerId", "SeatNo", "TripId" },
                values: new object[] { 1, 1, 1, 1, 1 });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Airplanes",
                keyColumn: "AirplaneId",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "Airplanes",
                keyColumn: "AirplaneId",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "Airplanes",
                keyColumn: "AirplaneId",
                keyValue: 4);

            migrationBuilder.DeleteData(
                table: "Airplanes",
                keyColumn: "AirplaneId",
                keyValue: 5);

            migrationBuilder.DeleteData(
                table: "Airplanes",
                keyColumn: "AirplaneId",
                keyValue: 6);

            migrationBuilder.DeleteData(
                table: "Cities",
                keyColumn: "CityId",
                keyValue: 9);

            migrationBuilder.DeleteData(
                table: "Cities",
                keyColumn: "CityId",
                keyValue: 10);

            migrationBuilder.DeleteData(
                table: "Passengers",
                keyColumn: "PassengerId",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "Tickets",
                keyColumn: "TicketId",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Trips",
                keyColumn: "TripId",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "Trips",
                keyColumn: "TripId",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "Trips",
                keyColumn: "TripId",
                keyValue: 4);

            migrationBuilder.DeleteData(
                table: "Trips",
                keyColumn: "TripId",
                keyValue: 5);

            migrationBuilder.DeleteData(
                table: "Trips",
                keyColumn: "TripId",
                keyValue: 6);

            migrationBuilder.DeleteData(
                table: "Trips",
                keyColumn: "TripId",
                keyValue: 7);

            migrationBuilder.DeleteData(
                table: "Trips",
                keyColumn: "TripId",
                keyValue: 8);

            migrationBuilder.DeleteData(
                table: "Trips",
                keyColumn: "TripId",
                keyValue: 9);

            migrationBuilder.DeleteData(
                table: "Trips",
                keyColumn: "TripId",
                keyValue: 10);

            migrationBuilder.DeleteData(
                table: "Trips",
                keyColumn: "TripId",
                keyValue: 11);

            migrationBuilder.DeleteData(
                table: "Trips",
                keyColumn: "TripId",
                keyValue: 12);

            migrationBuilder.DeleteData(
                table: "Trips",
                keyColumn: "TripId",
                keyValue: 13);

            migrationBuilder.DeleteData(
                table: "Trips",
                keyColumn: "TripId",
                keyValue: 14);

            migrationBuilder.DeleteData(
                table: "Trips",
                keyColumn: "TripId",
                keyValue: 15);

            migrationBuilder.DeleteData(
                table: "Trips",
                keyColumn: "TripId",
                keyValue: 16);

            migrationBuilder.DeleteData(
                table: "Trips",
                keyColumn: "TripId",
                keyValue: 17);

            migrationBuilder.DeleteData(
                table: "Trips",
                keyColumn: "TripId",
                keyValue: 18);

            migrationBuilder.DeleteData(
                table: "Trips",
                keyColumn: "TripId",
                keyValue: 19);

            migrationBuilder.DeleteData(
                table: "Trips",
                keyColumn: "TripId",
                keyValue: 20);

            migrationBuilder.DeleteData(
                table: "Trips",
                keyColumn: "TripId",
                keyValue: 21);

            migrationBuilder.DeleteData(
                table: "Trips",
                keyColumn: "TripId",
                keyValue: 22);

            migrationBuilder.DeleteData(
                table: "Trips",
                keyColumn: "TripId",
                keyValue: 23);

            migrationBuilder.DeleteData(
                table: "Trips",
                keyColumn: "TripId",
                keyValue: 24);

            migrationBuilder.DeleteData(
                table: "Trips",
                keyColumn: "TripId",
                keyValue: 25);

            migrationBuilder.DeleteData(
                table: "Trips",
                keyColumn: "TripId",
                keyValue: 26);

            migrationBuilder.DeleteData(
                table: "Trips",
                keyColumn: "TripId",
                keyValue: 27);

            migrationBuilder.DeleteData(
                table: "Trips",
                keyColumn: "TripId",
                keyValue: 28);

            migrationBuilder.DeleteData(
                table: "Trips",
                keyColumn: "TripId",
                keyValue: 29);

            migrationBuilder.DeleteData(
                table: "Trips",
                keyColumn: "TripId",
                keyValue: 30);

            migrationBuilder.DeleteData(
                table: "Trips",
                keyColumn: "TripId",
                keyValue: 31);

            migrationBuilder.DeleteData(
                table: "Trips",
                keyColumn: "TripId",
                keyValue: 32);

            migrationBuilder.DeleteData(
                table: "Trips",
                keyColumn: "TripId",
                keyValue: 33);

            migrationBuilder.DeleteData(
                table: "Trips",
                keyColumn: "TripId",
                keyValue: 34);

            migrationBuilder.DeleteData(
                table: "Trips",
                keyColumn: "TripId",
                keyValue: 35);

            migrationBuilder.DeleteData(
                table: "Trips",
                keyColumn: "TripId",
                keyValue: 36);

            migrationBuilder.DeleteData(
                table: "Trips",
                keyColumn: "TripId",
                keyValue: 37);

            migrationBuilder.DeleteData(
                table: "Trips",
                keyColumn: "TripId",
                keyValue: 38);

            migrationBuilder.DeleteData(
                table: "Trips",
                keyColumn: "TripId",
                keyValue: 39);

            migrationBuilder.DeleteData(
                table: "Trips",
                keyColumn: "TripId",
                keyValue: 40);

            migrationBuilder.DeleteData(
                table: "Cities",
                keyColumn: "CityId",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "Cities",
                keyColumn: "CityId",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "Cities",
                keyColumn: "CityId",
                keyValue: 4);

            migrationBuilder.DeleteData(
                table: "Cities",
                keyColumn: "CityId",
                keyValue: 6);

            migrationBuilder.DeleteData(
                table: "Cities",
                keyColumn: "CityId",
                keyValue: 7);

            migrationBuilder.DeleteData(
                table: "Cities",
                keyColumn: "CityId",
                keyValue: 8);

            migrationBuilder.DeleteData(
                table: "Passengers",
                keyColumn: "PassengerId",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Trips",
                keyColumn: "TripId",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Airplanes",
                keyColumn: "AirplaneId",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Cities",
                keyColumn: "CityId",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Cities",
                keyColumn: "CityId",
                keyValue: 5);
        }
    }
}
