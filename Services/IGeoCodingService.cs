using System.Threading.Tasks;
using Capstone.Models; 

namespace Capstone.Services
{
    public interface IGeoCodingService
    {
        public Task<Location> AttachLatAndLong(Location location);
    }
}