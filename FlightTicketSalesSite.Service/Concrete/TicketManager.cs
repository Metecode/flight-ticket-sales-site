using FlightTicketSalesSite.Service.Abstract;
using FlightTicketSalesSite.Data.Abstract;
using FlightTicketSalesSite.Entity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FlightTicketSalesSite.Service.Concrete
{
    public class TicketManager : ITicketService
    {
        private readonly ITicketRepository _ticketRepository;

        public TicketManager(ITicketRepository ticketRepository)
        {
            _ticketRepository = ticketRepository;
        }

        public async Task CreateAsync(Ticket ticket)
        {
            await _ticketRepository.CreateAsync(ticket);
        }



        public void Delete(Ticket ticket)
        {
            _ticketRepository.Delete(ticket);
        }

        public async Task<List<Ticket>> GetAllAsync()
        {
            return await _ticketRepository.GetAllAsync();

        }

        public async Task<Ticket> GetByIdAsync(int id)
        {
            return await _ticketRepository.GetByIdAsync(id);
        }

        public List<int> GetReservedSeat(int id)
        {
            return _ticketRepository.GetReservedSeat(id);
        }

        public async Task<Ticket> GetTicketByTrip(int id)
        {
            return await _ticketRepository.GetTicketByTrip(id);
        }

        public async Task<Ticket> GetTicketDetails(int id)
        {
            return await _ticketRepository.GetTicketDetails(id);
        }

        public void Update(Ticket ticket)
        {
            _ticketRepository.Update(ticket);
        }
    }
}
