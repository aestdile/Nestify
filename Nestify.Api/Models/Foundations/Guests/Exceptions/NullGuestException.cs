//==================================================
// Welcome! I'm Mukhtor C#.Net Junior Developer
// Residental Training Software
//==================================================


using System;
using Xeptions;

namespace Nestify.Api.Models.Foundations.Guests.Exceptions
{
    public class NullGuestException : Xeption
    {
        public NullGuestException() 
            : base(message: "The guest is null.") 
        {}
    }
}
