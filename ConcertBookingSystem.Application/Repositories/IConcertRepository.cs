using ConcertBookingSystem.Domain.Entities;
using ConcertBookingSystem.Application.Repositories.Common;


namespace ConcertBookingSystem.Application.Repositories
{
    public interface IConcertRepository :  IGenericRepository<Concert>
    {
        Concert Update(Concert entity);    
        Task<Concert> UpdateAync(Concert entity);    

    }
}
