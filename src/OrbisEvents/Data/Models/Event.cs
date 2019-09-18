using System;
using System.Collections.Generic;

namespace OrbisEvents.Data.Models
{
    public class Event
    {
        public int Id { get; set; }
        public string Title { get; set; }
        public string Description { get; set; }
        public DateTime? StartTime { get; set; }
        public DateTime? EndTime { get; set; }
        public int? MaxRegistrations { get; set; }
        public int? CreatedById { get; set; }
        public User CreatedBy { get; set; }

        public virtual ICollection<Registration> Registrations { get; set; }
    }
}