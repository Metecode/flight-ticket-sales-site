using FlightTicketSalesSite.Entity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FlightTicketSalesSite.Data.Abstract
{
    public interface ICityRepository
    {
        Task CreateAsync(City city);
        Task<List<City>> GellAllCitiesAsync(int id);
    }
}
