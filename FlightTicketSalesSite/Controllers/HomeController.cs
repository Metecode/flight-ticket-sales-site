using FlightTicketSalesSite.Models;
using FlightTicketSalesSite.Service.Abstract;
using Microsoft.AspNetCore.Mvc;
using System.Diagnostics;

namespace FlightTicketSalesSite.Controllers
{
    public class HomeController : Controller
    {
        private readonly ICityService _cityService;
        private readonly ITicketService _ticketService;
        private readonly IAirplaneService _airplaneService;
        private readonly ITripService _tripService;
        private readonly IPassengerService _passengerService;

        public HomeController(ICityService cityService, ITicketService ticketService, IAirplaneService airplaneService, ITripService tripService, IPassengerService passengerService)
        {
            _cityService = cityService;
            _ticketService = ticketService;
            _airplaneService = airplaneService;
            _tripService = tripService;
            _passengerService = passengerService;
        }

        public async Task<IActionResult> Index()
        {
            if (ModelState.IsValid)
            {
                var result = await _cityService.GetAllAsync();

                TicketRouteModel ticketRouteModel = new TicketRouteModel()
                {
                    Cities = result
                };

                return View(ticketRouteModel);
            }
            return View();

        }

        public async Task<IActionResult> TripList(TicketRouteModel ticketRouteModel)
        {
            if (ModelState.IsValid && ticketRouteModel != null && ticketRouteModel.FromWhereId != null && ticketRouteModel.ToWhereId != null && ticketRouteModel.FromWhereId != ticketRouteModel.ToWhereId)
            {

                var tripList = await _tripService.GetTripsAsync(ticketRouteModel.FromWhereId, ticketRouteModel.ToWhereId, ticketRouteModel.TripDate);


                List<TripListModel> tripModel = tripList.Select(t => new TripListModel
                {
                    TripId = t.TripId,
                    AirplaneId = t.AirplaneId,
                    Price = t.Price,
                    TripTime = t.TripTime,
                    FromWhereId = t.FromWhereId,
                    ToWhereId = t.ToWhereId,
                    FromWhere = t.FromWhere,
                    ToWhere = t.ToWhere
                }).ToList();
                return View(tripModel);
            }
            else
            {
                return RedirectToAction("");
            }
        }


        public async Task<IActionResult> TicketReservation(int id)
        {
            var price = _tripService.GetPrice(id);

            int seats = _tripService.GetSeats(id);
            List<int> seatNumbers = new List<int>();
            List<int> reservedSeat = _ticketService.GetReservedSeat(id);
            for (int i = 1; i <= seats; i++)
            {
                seatNumbers.Add(i);
            }
            foreach (var seat in reservedSeat)
            {
                seatNumbers.Remove(seat);
            }
            ViewBag.SeatNumbers = seatNumbers;

            TicketReservationModel ticketModel = new()
            {
                AirplaneId = (await _tripService.GetTripById(id)).AirplaneId,
                TripId = (await _tripService.GetTripById(id)).TripId,
                Price = price

            };
            return View(ticketModel);

        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}