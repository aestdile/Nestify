
//==================================================
// Welcome! I'm Mukhtor C#.Net Junior Developer
// Residental Training Software
//==================================================

using System;
using System.Threading.Tasks;
using Nestify.Api.Brokers.Storages;
using Nestify.Api.Models.Foundations.Guests;

namespace Nestify.Api.Services.Foundations.Guests
{
    public class GuestService: IGuestService
    {
        private readonly IStorageBroker storageBroker;

        public GuestService(IStorageBroker storageBroker) =>
            this.storageBroker = storageBroker;
        public ValueTask<Guest> AddGuestAsync(Guest guest) =>
            this.storageBroker.InsertGuestAsync(guest);
    }
}
