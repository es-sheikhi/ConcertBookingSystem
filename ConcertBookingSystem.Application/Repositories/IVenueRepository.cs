using ConcertBookingSystem.Domain.Entities;
using ConcertBookingSystem.Application.Repositories.Common;


namespace ConcertBookingSystem.Application.Repositories
{
    public interface IVenueRepository :  IGenericRepository<Venue>
    {
        Venue Update(Venue entity);  
        Task<Venue> UpdateAsync(Venue entity);  
    }
}
