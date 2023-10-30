/*
Copyright (c) is allowed for only 
education reasons. Author : DimaDev.
*/
using Sheenam.Api.Models.Foundations.Guests;
using System.Threading.Tasks;

namespace Sheenam.Api.Broker.Storages
{
    public partial interface IStorageBroker
    {
        ValueTask<Guest> InsertGuestAsync(Guest guest);
    }
}
