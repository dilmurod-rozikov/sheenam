using Microsoft.EntityFrameworkCore;
using Sheenam.Api.Models.Foundations.Guests;

namespace Sheenam.Api.Broker.Storages
{
    public partial class Strogebroker
    {
        public DbSet<Guest> Guests { get; set; }
    }
}
