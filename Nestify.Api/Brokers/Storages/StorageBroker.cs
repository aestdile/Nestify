
//===================================
// Welcome Aestdile Startup Company
// Residental Training Software
//===================================


using System.Threading.Tasks;
using EFxceptions;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Nestify.Api.Models.Foundations.Guests;

namespace Nestify.Api.Brokers.Storages
{
    public partial class StorageBroker: EFxceptionsContext, IStorageBroker
    {
        private readonly IConfiguration configuration;

        public StorageBroker(IConfiguration configuration)
        {
            this.configuration = configuration;
            this.Database.Migrate();
        }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            string connectionString = 
                this.configuration.GetConnectionString(name: "DefaultConnection");


            optionsBuilder.UseSqlServer(connectionString);

        }

        public override void Dispose(){}

        ValueTask<Guest> IStorageBroker.InsertGuestAsync(Guest guest)
        {
            throw new System.NotImplementedException();
        }
    }
}
