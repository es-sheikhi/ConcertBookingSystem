using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConcertBookingSystem.Domain.Entities
{
    public class Ticket
    {
        public int TicketId { get; set; }
        public required int SeatNumber { get; set; }
        [Required]
        public bool IsBooked { get; set; }
        [ForeignKey(nameof(BookingId))]
        public int? BookingId { get; set; }
        public Booking Booking { get; set; }
    }
}
