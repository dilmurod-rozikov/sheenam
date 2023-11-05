/*
Copyright (c) is allowed for only 
education reasons. Author : DimaDev.
*/
using FluentAssertions;
using Moq;
using Sheenam.Api.Broker.Storages;
using Sheenam.Api.Models.Foundations.Guests;
using Sheenam.Api.Services.Foundations.Guests;
using Xunit;

namespace Sheenam.Api.Tests.Unit.Service.Foundations.Guests
{
    public partial class GuestServiceTests
    {
        private readonly Mock<IStorageBroker> storageBrokerMock;
        private readonly IGuestService guestService;
        public GuestServiceTests()
        {
            this.storageBrokerMock = new Mock<IStorageBroker>();

            this.guestService = 
                new GuestService(storageBroker: this.storageBrokerMock.Object);
        }
        [Fact]
        public async Task CreateRandomGuest()
        {

            //Arrange
            Guest randomGuest = new Guest
            {
                Id = Guid.NewGuid(),
                FirstName = "Dilmurod",
                LastName = "Kahramonov",
                Email = "something@gmail.com",
                Address = "Somewhere in the middle of nowhere",
                PhoneNumber = "bla bla bla",
                DateOfBirth = new DateTimeOffset(),
                Gender = GenderType.Male
            };

            this.storageBrokerMock.Setup(broker =>
                broker.InsertGuestAsync(randomGuest))
                    .ReturnsAsync(randomGuest);

            //Act
            Guest actual = await this.guestService.AddGuestAsync(randomGuest);

            //Assert
             actual.Should().BeEquivalentTo(randomGuest);

        }
    }
}
