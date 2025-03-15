using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConcertBookingSystem.Domain.Entities
{
    public class ApplicationUser
    {
        public ICollection<Booking> Bookings { get; set; } = new List<Booking>();
    }
}
