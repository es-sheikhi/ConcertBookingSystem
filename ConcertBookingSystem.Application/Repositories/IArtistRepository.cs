using ConcertBookingSystem.Application.Repositories.Common;
using ConcertBookingSystem.Domain.Entities;


namespace ConcertBookingSystem.Application.Repositories
{
    public interface IArtistRepository:IGenericRepository<Artist>
    {
        Artist Update(Artist entity);
        Task<Artist> UpdateAsync(Artist entity);
    }
}
