
//==================================================
// Welcome! I'm Mukhtor C#.Net Junior Developer
// Residental Training Software
//==================================================


using System.Threading.Tasks;
using EFxceptions;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.Logging;
using Nestify.Api.Models.Foundations.Guests;

namespace Nestify.Api.Brokers.Storages
{
    public partial class StorageBroker: EFxceptionsContext, IStorageBroker
    {
        private readonly IConfiguration configuration;

        private readonly ILogger<StorageBroker> logger;

        public StorageBroker(IConfiguration configuration, ILogger<StorageBroker> logger)
        {
            this.configuration = configuration;
            this.Database.Migrate();
            this.logger = logger;
        }
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
