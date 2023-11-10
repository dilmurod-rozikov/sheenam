/*
Copyright (c) is allowed for only 
education reasons. Author : DimaDev.
*/
using Sheenam.Api.Broker.Storages;
using Sheenam.Api.Models.Foundations.Guests;
using System.Threading.Tasks;
using System;

namespace Sheenam.Api.Services.Foundations.Guests
{
    public class GuestService : IGuestService
    {
        private readonly IStorageBroker storageBroker;
        public GuestService(IStorageBroker storageBroker) =>
            this.storageBroker = storageBroker;
        
        public async ValueTask<Guest> AddGuestAsync(Guest guest) =>
              await this.storageBroker.InsertGuestAsync(guest);
        
    }
}
