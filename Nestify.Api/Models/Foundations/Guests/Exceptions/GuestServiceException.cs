using Xeptions;

namespace Nestify.Api.Models.Foundations.Guests.Exceptions
{
    public class GuestServiceException : Xeption
    {
        public GuestServiceException(Xeption innerException)
            : base(message: "Guest service error occured, contact support",
                  innerException)
        { }
    }
}
