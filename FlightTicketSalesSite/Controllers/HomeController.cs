﻿using FlightTicketSalesSite.Core;
using FlightTicketSalesSite.Entity;
using FlightTicketSalesSite.Models;
using FlightTicketSalesSite.Service.Abstract;
using FlightTicketSalesSite.Services;
using Iyzipay;
using Iyzipay.Model;
using Iyzipay.Request;
using Microsoft.AspNetCore.Localization;
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
        private LanguageService _localization;
        public HomeController(ICityService cityService, ITicketService ticketService, IAirplaneService airplaneService, ITripService tripService, IPassengerService passengerService, LanguageService localization)
        {
            _cityService = cityService;
            _ticketService = ticketService;
            _airplaneService = airplaneService;
            _tripService = tripService;
            _passengerService = passengerService;
            _localization = localization;
        }

        public async Task<IActionResult> Index()
        {
            ViewBag.Welcome = _localization.Getkey("Welcome").Value;
            var currentCulture = Thread.CurrentThread.CurrentCulture.Name;
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

        public IActionResult ChangeLanguage(string culture)
        {
            Response.Cookies.Append(CookieRequestCultureProvider.DefaultCookieName,
                CookieRequestCultureProvider.MakeCookieValue(new RequestCulture(culture)), new CookieOptions()
                {
                    Expires = DateTimeOffset.UtcNow.AddYears(1)
                });
            return Redirect(Request.Headers["Referer"].ToString());
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

        [HttpPost]
        public async Task<IActionResult> TicketReservation(TicketReservationModel ticketModel, int seatNumber, int id)
        {
            if (ModelState.IsValid)
            {
                var price = _tripService.GetPrice(id);
                ticketModel.Price = price;

                var trip = await _tripService.GetTripById(ticketModel.TripId);
                //ticketModel.Price = price;

                ticketModel.SeatNo = seatNumber;
                ticketModel.TripDate = trip.TripDate;
                ticketModel.TripTime = trip.TripTime;
                ticketModel.FromWhereId = trip.FromWhereId;
                ticketModel.ToWhereId = trip.ToWhereId;


                Options options = new Options();
                options.ApiKey = "sandbox-QqmaQRzpdEJmqLbtVB4oWRpknarFy8nv";
                options.SecretKey = "sandbox-LWVjxzHJNFfooDR6YJelsumk9if6ykBH";
                options.BaseUrl = "https://sandbox-api.iyzipay.com";

                CreatePaymentRequest request = new CreatePaymentRequest();
                request.Locale = Locale.TR.ToString();
                request.ConversationId = "123456789";
                request.Price = ticketModel.Price.ToString().Replace(",", ".");
                request.PaidPrice = ticketModel.Price.ToString().Replace(",", ".");
                request.Currency = Currency.TRY.ToString();
                request.Installment = 1;
                request.BasketId = "B67832";
                request.PaymentChannel = PaymentChannel.WEB.ToString();
                request.PaymentGroup = PaymentGroup.PRODUCT.ToString();

                PaymentCard paymentCard = new PaymentCard();
                paymentCard.CardHolderName = ticketModel.CardHolderName;
                paymentCard.CardNumber = ticketModel.CardNumber;
                paymentCard.ExpireMonth = ticketModel.ExpireMonth;
                paymentCard.ExpireYear = ticketModel.ExpireYear;
                paymentCard.Cvc = ticketModel.Cvc;
                paymentCard.RegisterCard = 0;
                request.PaymentCard = paymentCard;

                Buyer buyer = new Buyer();
                buyer.Id = "BY789";
                buyer.Name = ticketModel.FirstName;
                buyer.Surname = ticketModel.LastName;
                buyer.GsmNumber = ticketModel.PhoneNumber;
                buyer.Email = ticketModel.Email;
                buyer.IdentityNumber = ticketModel.IdentityNumber;
                buyer.LastLoginDate = "2015-10-05 12:43:35";
                buyer.RegistrationDate = "2013-04-21 15:12:09";
                buyer.RegistrationAddress = "Nidakule Göztepe, Merdivenköy Mah. Bora Sok. No:1";
                buyer.Ip = "85.34.78.112";
                buyer.City = "Istanbul";
                buyer.Country = "Turkey";
                buyer.ZipCode = "34732";
                request.Buyer = buyer;

                Address shippingAddress = new Address();
                shippingAddress.ContactName = "Jane Doe";
                shippingAddress.City = "Istanbul";
                shippingAddress.Country = "Turkey";
                shippingAddress.Description = "Nidakule Göztepe, Merdivenköy Mah. Bora Sok. No:1";
                shippingAddress.ZipCode = "34742";
                request.ShippingAddress = shippingAddress;

                Address billingAddress = new Address();
                billingAddress.ContactName = "Jane Doe";
                billingAddress.City = "Istanbul";
                billingAddress.Country = "Turkey";
                billingAddress.Description = "Nidakule Göztepe, Merdivenköy Mah. Bora Sok. No:1";
                billingAddress.ZipCode = "34742";
                request.BillingAddress = billingAddress;

                List<BasketItem> basketItems = new List<BasketItem>();
                BasketItem firstBasketItem = new BasketItem();
                firstBasketItem.Id = "BI101";
                firstBasketItem.Name = "Binocular";
                firstBasketItem.Category1 = "Collectibles";
                firstBasketItem.Category2 = "Accessories";
                firstBasketItem.ItemType = BasketItemType.PHYSICAL.ToString();
                firstBasketItem.Price = ticketModel.Price.ToString().Replace(",", ".");
                basketItems.Add(firstBasketItem);
                request.BasketItems = basketItems;



                Payment payment = Payment.Create(request, options);

                if (payment.Status == "success")
                {
                    Passenger passenger = new Passenger()
                    {
                        FirstName = ticketModel.FirstName,
                        LastName = ticketModel.LastName,
                        Email = ticketModel.Email,
                        PhoneNumber = ticketModel.PhoneNumber,
                    };
                    await _passengerService.CreateAsync(passenger);

                    Ticket ticket = new Ticket()
                    {
                        PassengerId = passenger.PassengerId,
                        TripId = ticketModel.TripId,
                        SeatNo = seatNumber,
                        AirplaneId = ticketModel.AirplaneId
                    };
                    await _ticketService.CreateAsync(ticket);
                    TempData["AlertMessage"] = Jobs.CreateMessage("Success!", "Your payment has been successfully received!", "success");
                    return RedirectToAction("TicketInfo", ticketModel);

                }
                TempData["AlertMessage"] = Jobs.CreateMessage("Unsuccessful!", payment.ErrorMessage, "danger");

            }

            return RedirectToAction("TicketReservation", ticketModel);

        }

        public async Task<IActionResult> TicketInfo(TicketDetailsModel ticketModel)
        {
            var trip = await _tripService.GetTripById(ticketModel.TripId);
            TicketDetailsModel ticketDetails = new TicketDetailsModel()
            {
                FirstName = ticketModel.FirstName,
                LastName = ticketModel.LastName,
                Email = ticketModel.Email,
                PhoneNumber = ticketModel.PhoneNumber,
                SeatNo = ticketModel.SeatNo,
                TripDate = ticketModel.TripDate,
                TripTime = ticketModel.TripTime,
                FromWhereId = ticketModel.FromWhereId,
                ToWhereId = ticketModel.ToWhereId,
                FromWhere = trip.FromWhere,
                ToWhere = trip.ToWhere

            };

            return View(ticketDetails);
        }
    }
}