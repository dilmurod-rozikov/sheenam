using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sheenam.Api.Tests.Unit.Service.Foundations.Guests
{
    public partial class GuestServiceTest
    {
        [Fact]
        public async Task ShouldThrowValidationExceptionOnAddIfGuestIsNullAndLogItAsync()
        {
            //given
            Guest nullGuest = null;
            var nullGuestException = new NullGuestException();

            var expectedGuestValidationException = 
                new GuestValidationException(nullGuestException);

            //when
            ValueTask<Guest> addGuestTask =
                this.guestServiceAddGuestAsync(nullGuest);


            //then
            await Assert.ThrowsAsync<GuestValidationException>(() =>
            addGuestTask.AsTask());

        }


    }
}
