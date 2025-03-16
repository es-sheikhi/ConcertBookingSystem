using ConcertBookingSystem.Domain.Entities;
using ConcertBookingSystem.Application.Repositories.Common;


namespace ConcertBookingSystem.Application.Repositories
{
    public interface ITicketRepository :  IGenericRepository<Ticket>
    {
    }
}
