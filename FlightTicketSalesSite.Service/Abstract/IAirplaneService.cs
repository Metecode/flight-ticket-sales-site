using FlightTicketSalesSite.Entity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FlightTicketSalesSite.Service.Abstract
{
    public interface IAirplaneService
    {
        Task<Airplane> GetByIdAsync(int id);
        Task<List<Airplane>> GetAllAsync();

        Task CreateAsync(Airplane airplane);
        void Update(Airplane airplane);
        void Delete(Airplane airplane);

        int GetSeats(int id);
    }
}
