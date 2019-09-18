using OrbisEvents.Data;
using OrbisEvents.Data.Models;

namespace OrbisEvents.Core.Repository
{
    public class EventRepository : Repository<Event>
    {
        public EventRepository(AppDbContext context) : base(context)
        {
        }
    }
}