using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConcertBookingSystem.Domain.Entities
{
    public class Booking
    {
        [Key]
        public int BookingId { get; set; }
        [Required]
        public DateTime BookingDate { get; set; }
        [Required]
        [ForeignKey(nameof(ConcertId))]
        public int ConcertId { get; set; }
        public Concert Concert { get; set; }
        [Required]
        [ForeignKey(nameof(ApplicatoinUserId))]
        public int ApplicatoinUserId { get; set; }
        public ApplicationUser ApplicationUser { get; set; }

        public ICollection<Ticket> Tickets { get; set; }
    }
}
