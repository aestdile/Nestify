﻿//==================================================
// Welcome! I'm Mukhtor C#.Net Junior Developer
// Residental Training Software
//==================================================



using FluentAssertions;
using Moq;
using Nestify.Api.Models.Foundations.Guests;
using Xunit;

namespace Nestify.Api.Tests.Unit.Services.Foundations.Guests
{
    public partial class GuestServiceTests // Vazifasi: parametrni olib, Brokerga berish
    {
        // Test boshlandi

        [Fact]
        public async Task ShouldAddGuestAsync()
        {
            // given
            Guest randomGuest = CreateRandomGuest();
            Guest inputGuest = randomGuest;
            Guest returningGuest =inputGuest;
            Guest expectedGuest = returningGuest;

            this.storageBrokerMock.Setup(broker =>
            broker.InsertGuestAsync(inputGuest))
                .ReturnsAsync(returningGuest);

            // when
            Guest actualGuest=
                await this.guestService.AddGuestAsync(inputGuest);


            // then
            actualGuest.Should().BeEquivalentTo(expectedGuest);

            this.storageBrokerMock.Verify(broker =>
            broker.InsertGuestAsync(inputGuest),
                Times.Once);

            this.storageBrokerMock.VerifyNoOtherCalls();



        }
    }
}
