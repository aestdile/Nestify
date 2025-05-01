
//==================================================
// Welcome! I'm Mukhtor C#.Net Junior Developer
// Residental Training Software
//==================================================

using System;
using System.Threading.Tasks;
using Nestify.Api.Brokers.Storages;
using Nestify.Api.Models.Foundations.Guests;
using Nestify.Api.Models.Foundations.Guests.Exceptions;

namespace Nestify.Api.Services.Foundations.Guests
{
    public class GuestService: IGuestService
    {
        private readonly IStorageBroker storageBroker;

        public GuestService(IStorageBroker storageBroker) =>
            this.storageBroker = storageBroker;
        public async ValueTask<Guest> AddGuestAsync(Guest guest)
        {
            if (guest is null)
                throw new GuestValidationException(new NullGuestException());

            return await this.storageBroker.InsertGuestAsync(guest);
        }

    }
}
