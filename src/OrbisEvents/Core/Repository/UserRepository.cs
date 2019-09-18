using OrbisEvents.Data;
using OrbisEvents.Data.Models;

namespace OrbisEvents.Core.Repository
{
    public class UserRepository : Repository<User>
    {
        public UserRepository(AppDbContext context) : base(context)
        {
        }
    }
}