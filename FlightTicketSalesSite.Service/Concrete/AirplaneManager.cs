using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using FlightTicketSalesSite.Service.Abstract;
using FlightTicketSalesSite.Data.Abstract;
using FlightTicketSalesSite.Entity;

namespace FlightTicketSalesSite.Service.Concrete
{
    public class AirplaneManager : IAirplaneService
    {
        private IAirplaneRepository _airplaneRepository;

        public AirplaneManager(IAirplaneRepository airplaneRepository)
        {
            _airplaneRepository = airplaneRepository;
        }

        public async Task CreateAsync(Airplane airplane)
        {
            await _airplaneRepository.CreateAsync(airplane);
        }

        public void Delete(Airplane airplane)
        {
            _airplaneRepository.Delete(airplane);
        }

        public async Task<List<Airplane>> GetAllAsync()
        {
            return await _airplaneRepository.GetAllAsync();
        }

        public async Task<Airplane> GetByIdAsync(int id)
        {
            return await _airplaneRepository.GetByIdAsync(id);
        }

        public int GetSeats(int id)
        {
            return _airplaneRepository.GetSeats(id);
        }

        public void Update(Airplane airplane)
        {
            _airplaneRepository.Update(airplane);
        }
    }
}
