/*
Copyright (c) is allowed for only 
education reasons. Author : DimaDev.
*/
using Sheenam.Api.Broker.Storages;
using Sheenam.Api.Models.Foundations.Guests;
using System;
using System.Threading.Tasks;

namespace Sheenam.Api.Services.Foundations.Guests
{
    public interface IGuestService { 
       public ValueTask<Guest> AddGuestAsync(Guest guest);

    }
}
