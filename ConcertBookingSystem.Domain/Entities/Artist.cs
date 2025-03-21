﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConcertBookingSystem.Domain.Entities
{
    public class Artist
    {
        [Key]
        public int Id { get; set; }

        public required string Name { get; set; }
        public string? Bio { get; set; }
        public string? ImageUrl { get; set; }
        public ICollection<Concert> Concerts { get; set; }
    }
}
