using System;

namespace OrbisEvents.Data.Models
{
    public class Registration
    {
        public int Id { get; set; }
        public DateTime? DateRegistered { get; set; }
        public int? EventId { get; set; }
        public int? UserId { get; set; }
        public Event Event { get; set; }
        public User User { get; set; }
    }
}