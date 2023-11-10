using Sheenam.Api.Models.Foundations.Guests;
using Tynamix.ObjectFiller;
using Xunit;
/*
Copyright (c) is allowed for only 
education reasons. Author : DimaDev.
*/
internal static class GuestServiceTestsHelpers
{

    private static Filler<Guest> CreateGuestFiller(DateTimeOffset date)
    {
        var filler = new Filler<Guest>();
        filler.Setup().OnType<DateTimeOffset>().Use(date);
        return filler;
    }

    [Fact]
    private static Guest CreateRandomGuest()
    {
        Guest guest = CreateGuestFiller(date: GetRandomDateTimeOffset()).Create();
        return guest;
    }

    private static DateTimeOffset GetRandomDateTimeOffset()
    {
        return new DateTimeRange(earliestDate: new DateTime()).GetValue();
    }
}