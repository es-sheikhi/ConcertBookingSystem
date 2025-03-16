﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConcertBookingSystem.Application.Repositories.Common
{
    public interface IUnitOfWork
    {
        IArtistRepository ArtistRepository { get; }
        IBookingRepository BookingRepository { get; }
        IConcertRepository ConcertRepository { get; }
        ITicketRepository TicketRepository { get; }
        IVenueRepository VenueRepository { get; }
        bool Save();
        Task<bool> SaveAsync();
    }
}
