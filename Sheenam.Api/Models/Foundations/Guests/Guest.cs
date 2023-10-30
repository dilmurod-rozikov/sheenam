﻿/*
Copyright (c) is allowed for only 
education reasons. Author : DimaDev.
*/

using System;

namespace Sheenam.Api.Models.Foundations.Guests
{
    public class Guest
    {
        public Guid MyProperty { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public DateTimeOffset DateOfBirth { get; set; }
        public string Email { get; set; }
        public string Address { get; set; }
        public string PhoneNumber { get; set; }
        public GenderType Gender { get; set; }



    }
}