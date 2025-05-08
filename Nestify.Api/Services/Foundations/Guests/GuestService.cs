
//==================================================
// Welcome! I'm Mukhtor C#.Net Junior Developer
// Residental Training Software
//==================================================

using System.Threading.Tasks;
using Nestify.Api.Brokers.Loggings.ILoggingBroker;
using Nestify.Api.Brokers.Storages;
using Nestify.Api.Models.Foundations.Guests;
using Nestify.Api.Models.Foundations.Guests.Exceptions;

namespace Nestify.Api.Services.Foundations.Guests
{
    public partial class GuestService : IGuestService
    {
        private readonly IStorageBroker storageBroker;
        private readonly ILoggingBroker loggingBroker;

        public GuestService(
            IStorageBroker storageBroker,
            ILoggingBroker loggingBroker)
        {
            this.storageBroker = storageBroker;
            this.loggingBroker = loggingBroker;
        }
        public ValueTask<Guest> AddGuestAsync(Guest guest) =>
        TryCatch(async () =>
        {
            ValidateGuestOnAdd(guest);

            return await this.storageBroker.InsertGuestAsync(guest);
        });
    }
}
