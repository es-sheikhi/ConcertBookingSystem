using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConcertBookingSystem.Application.Repositories.Common
{
    public interface IDbInitial
    {
        void Seed();
        Task SeedAsync();
    }
}
