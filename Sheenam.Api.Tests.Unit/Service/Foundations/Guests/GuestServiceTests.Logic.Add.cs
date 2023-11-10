using FluentAssertions;
using Force.DeepCloner;
using Moq;
using Sheenam.Api.Models.Foundations.Guests;
using Xunit;

namespace Sheenam.Api.Tests.Unit.Service.Foundations.Guests
{
    public partial class GuestServiceTests
    {
       /* [Fact]
        public async Task ShouldAddGuestAsyncInWrongWayAsync()
        {
            //Arrange
            Guest randomGuest = new Guest()
            {
                FirstName = "Dilmurod",
                LastName = "Rozikov",
                Email = "dasda@gmail.com",
                Address = "Tashkent, Mirzo Ulugbek",
                DateOfBirth = new DateTimeOffset(),
                Gender = GenderType.Male,
                PhoneNumber = "231231231",
                Id = Guid.NewGuid()

            };

            this.storageBrokerMock.Setup(broker =>
                broker.InsertGuestAsync(randomGuest))
                .ReturnsAsync(randomGuest);
            //Act
            Guest actual =
                await this.guestService.AddGuestAsync(randomGuest);

            //Assert
            actual.Should().BeEquivalentTo(randomGuest);

        }

       */ 
        [Fact]
        public async Task ShouldAddGuestAsync()
        {
            //given
            Guest randomGuest = CreateRandomGuests();
            Guest inputGuest = randomGuest;
            Guest returningGuest = inputGuest;
            Guest expectedGuest = returningGuest.DeepClone();

            this.storageBrokerMock.Setup(broker =>
                broker.InsertGuestAsync(inputGuest))
                .ReturnsAsync(returningGuest);

            //when
            Guest actualGuest =
               await guestService.AddGuestAsync(inputGuest);

            //then
            actualGuest.Should().BeEquivalentTo(expectedGuest);

            this.storageBrokerMock.Verify(broker =>
                broker.InsertGuestAsync(inputGuest),
                Times.Once);

            this.storageBrokerMock.VerifyNoOtherCalls();

        }
        }
    }
