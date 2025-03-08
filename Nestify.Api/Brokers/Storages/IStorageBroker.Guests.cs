
//==================================================
// Welcome! I'm Mukhtor C#.Net Junior Developer
// Residental Training Software
//==================================================


using System.Threading.Tasks;
using Nestify.Api.Models.Foundations.Guests;

namespace Nestify.Api.Brokers.Storages
{
    public partial interface IStorageBroker
    {
        ValueTask<Guest> InsertGuestAsync(Guest guest);
    }
}
