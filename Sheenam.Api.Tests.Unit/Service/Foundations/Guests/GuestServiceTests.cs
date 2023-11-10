/*
Copyright (c) is allowed for only 
education reasons. Author : DimaDev.
*/
using Moq;
using Sheenam.Api.Broker.Storages;
using Sheenam.Api.Models.Foundations.Guests;
using Sheenam.Api.Services.Foundations.Guests;
using Tynamix.ObjectFiller;
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

        private static Guest CreateRandomGuests()
        {
            return CreateGuestFiller(date: GetRandomDateTimeOffset()).Create();
        }

        private static DateTimeOffset GetRandomDateTimeOffset()
        {
            return new DateTimeRange(earliestDate: new DateTime()).GetValue();
        }

        private static Filler<Guest> CreateGuestFiller(DateTimeOffset date)
        {
            var filler = new Filler<Guest>();
            filler.Setup().OnType<DateTimeOffset>().Use(date);
            return filler;
        }
    }
}
