using System.Threading.Tasks;
using Nestify.Api.Models.Foundations.Guests;
using Nestify.Api.Models.Foundations.Guests.Exceptions;
using Xeptions;

namespace Nestify.Api.Services.Foundations.Guests
{
    public partial class GuestService
    {
        private delegate ValueTask<Guest> ReturningGuestFunction();

        private async ValueTask<Guest> TryCatch(ReturningGuestFunction returningGuestFunction)
        {
            try
            {
                return await returningGuestFunction();
            }
            catch (NullGuestException nullGuestException)
            {
                throw CreateAndLogValidationException(nullGuestException);
            }
        }

        private GuestValidationException CreateAndLogValidationException(Xeption exception)
        {
            var guestValidationException =
                    new GuestValidationException(exception);

            this.loggingBroker.LogError(guestValidationException);

            return guestValidationException;
        }
    }
}
