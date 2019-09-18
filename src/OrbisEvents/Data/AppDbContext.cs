using Microsoft.EntityFrameworkCore;
using OrbisEvents.Data.Models;

namespace OrbisEvents.Data
{
    public class AppDbContext : DbContext
    {
        public AppDbContext(DbContextOptions<AppDbContext> options)
            : base(options)
        {
        }

        public DbSet<User> Users { get; set; }
        public DbSet<Event> Events { get; set; }
        public DbSet<Registration> Registrations { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<User>(b => b.ToTable("users"));
            modelBuilder.Entity<Event>(b => b.ToTable("events"));
            modelBuilder.Entity<Registration>(b => b.ToTable("registrations"));
        }
    }
}