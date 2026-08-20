using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Text;

namespace G_NET_55_EF_02
{
    public class EventHubContext : DbContext
    {
        public DbSet<Organizer> Organizers { get; set; }
        public DbSet<Profile> Profiles { get; set; }
        public DbSet<Event> Events { get; set; }
        public DbSet<Session> Sessions { get; set; }
        public DbSet<Attendee> Attendees { get; set; }
        public DbSet<Badge> Badges { get; set; }
        public DbSet<Registration> Registrations { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            // Profile باستخدام Fluent API
            modelBuilder.Entity<Profile>()
                .HasOne(p => p.Organizer)
                .WithOne(o => o.Profile)
                .HasForeignKey<Profile>(p => p.OrganizerId);

            // Attendee باستخدام Fluent API
            modelBuilder.Entity<Attendee>()
                .HasIndex(a => a.Email)
                .IsUnique();

            // استدعاء Configurations
            modelBuilder.ApplyConfiguration(new EventConfiguration());
            modelBuilder.ApplyConfiguration(new BadgeConfiguration());
        }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer(@"Server=.;Database=EventHubDB;Trusted_Connection=True;");
        }
    }
}
