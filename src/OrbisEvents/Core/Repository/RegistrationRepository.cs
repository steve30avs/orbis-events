using OrbisEvents.Data;
using OrbisEvents.Data.Models;

namespace OrbisEvents.Core.Repository
{
    public class RegistrationRepository : Repository<Registration>
    {
        public RegistrationRepository(AppDbContext context) : base(context)
        {
        }
    }
}