using System;
using System.Data;
using Nestify.Api.Models.Foundations.Guests;
using Nestify.Api.Models.Foundations.Guests.Exceptions;

namespace Nestify.Api.Services.Foundations.Guests
{
    public partial class GuestService
    {
        private void ValidateGuestOnAdd(Guest guest)
        {
            ValidateGuestNotNull(guest);

            Validate(
                (Rule: IsInvalid(guest.Id), Paramater: nameof(Guest.Id)),
                (Rule: IsInvalid(guest.FirstName), Paramater: nameof(Guest.FirstName)),
                (Rule: IsInvalid(guest.LastName), Paramater: nameof(Guest.LastName)),
                (Rule: IsInvalid(guest.DateOfBirth), Paramater: nameof(Guest.DateOfBirth)),
                (Rule: IsInvalid(guest.Email), Paramater: nameof(Guest.Email)),
                (Rule: IsInvalid(guest.Address), Paramater: nameof(Guest.Address))
                );
        }
        private void ValidateGuestNotNull(Guest guest)
        {
            if (guest is null)
            {
                throw new NullGuestException();
            }
        }

        private static dynamic IsInvalid(Guid id) => new
        {
            Condition = id == Guid.Empty,
            Message = "Id is required"
        };

        private static dynamic IsInvalid(string text) => new
        {
            Condition = string.IsNullOrWhiteSpace(text),
            Message = "Text is required"
        };

        private static dynamic IsInvalid( DateTimeOffset date) => new
        {
            Condition = date == default,
            Message = "Data is required"
        };



        private static void Validate(params (dynamic Rule, string Parameter)[] validations)
        {
            var invalidGuestException = new InvalidGuestException();

            foreach ((dynamic rule, string parameter) in validations)
            {
                if (rule.Condition)
                {
                    invalidGuestException.UpsertDataList(
                        key: parameter,
                        value: rule.Message);
                }
            }

            invalidGuestException.ThrowIfContainsErrors();
        }
    }
}
