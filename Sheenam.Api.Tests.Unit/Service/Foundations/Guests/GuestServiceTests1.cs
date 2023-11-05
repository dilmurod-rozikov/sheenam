﻿/*
Copyright (c) is allowed for only 
education reasons. Author : DimaDev.
*/
using FluentAssertions;
using Force.DeepCloner;
using Moq;
using Sheenam.Api.Broker.Storages;
using Sheenam.Api.Models.Foundations.Guests;
using Sheenam.Api.Services.Foundations.Guests;
using Xunit;

namespace Sheenam.Api.Tests.Unit.Service.Foundations.Guests
{
    public partial class GuestServiceTests
    {
        public GuestServiceTests(Mock<IStorageBroker> storageBrokerMock, IGuestService guestService)
        {
            this.storageBrokerMock = storageBrokerMock;
            this.guestService = guestService;
        }

        [Fact]
        public async Task ShouldAddGuestAsync()
        { 
            //given
            Guest randomGuest = CreateRandomGuest();
            Guest inputGuest = randomGuest;
            Guest storageGuest = inputGuest;
            Guest expectedGuest = storageGuest.DeepClone();

            this.storageBrokerMock.Setup(broker =>
                broker.InsertGuestAsync(inputGuest))
                .ReturnsAsync(storageGuest);
            //when
            Guest actualGuest =
                await this.guestService.AddGuestAsync(inputGuest);

            //then
            actualGuest.Should().BeEquivalentTo(expectedGuest);

            this.storageBrokerMock.Verify(broker =>
                broker.InsertGuestAsync(inputGuest),
                    Times.Once);

            this.storageBrokerMock.VerifyNoOtherCalls();

        }
    }
}