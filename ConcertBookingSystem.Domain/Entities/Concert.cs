using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConcertBookingSystem.Domain.Entities
{
    public class Concert
    {
        [Key]
        public int Id { get; set; }

        public required string Name { get; set; }
        public string? Description { get; set; }
        public string? ImageUrl { get; set; }
        [Required]
        public DateTime DateTime { get; set; }

        [Required]
        [ForeignKey(nameof(ArtistId))]
        public int ArtistId { get; set; }
        public Artist Artist { get; set; }

        [Required]
        [ForeignKey(nameof(VenueId))]
        public int VenueId { get; set; }  
        public Venue Venue { get; set; }

        public ICollection<Booking> Bookings { get; set; }
    }
}
