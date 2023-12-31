﻿using FlightTicketSalesSite.Entity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FlightTicketSalesSite.Data.Abstract
{
    public interface IPassengerRepository : IRepository<Passenger>
    {
        Task CreateAsync(Passenger passenger, int seatNumber, int id);
    }
}
