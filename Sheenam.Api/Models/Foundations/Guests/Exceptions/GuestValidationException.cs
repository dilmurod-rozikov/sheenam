﻿using Xeptions;

namespace Sheenam.Api.Models.Foundations.Guests.Exceptions
{
    public class GuestValidationException : Xeption
    {
        public GuestValidationException(Xeption innerException)
            :base(message: "Guest validation error occurred, fix errors and try again",
                 innerException)
        {}
    }
}
