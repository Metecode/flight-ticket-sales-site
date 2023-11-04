using FlightTicketSalesSite.Entity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FlightTicketSalesSite.Data.Abstract
{
    internal interface ICityRepository
    {
        Task<List<City>> GellAllCitiesAsync(int id);
    }
}
