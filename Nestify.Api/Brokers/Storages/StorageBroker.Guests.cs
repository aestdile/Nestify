
//===================================
// Welcome Aestdile Startup Company
// Residental Training Software
//===================================

using Microsoft.EntityFrameworkCore;
using Nestify.Api.Models.Foundations.Guests;


namespace Nestify.Api.Brokers.Storages
{
    public partial class StorageBroker
    {
        public DbSet<Guest> Guests { get; set; }
    }
}
