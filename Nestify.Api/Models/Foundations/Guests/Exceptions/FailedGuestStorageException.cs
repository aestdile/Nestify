//==================================================
// Copyright(c) Coalition of Good-Hearted-Engineers
// Free To Use To Find Comfort and Peace
//==================================================

using System;
using Xeptions;

namespace Nestify.Api.Models.Foundations.Guests.Exceptions
{
    public class FailedGuestStorageException : Xeption
    {
        public FailedGuestStorageException(Exception innerException) 
            : base (message: "Failed guest storage error occured, contact support",
            innerException)
        { }
    }
}
