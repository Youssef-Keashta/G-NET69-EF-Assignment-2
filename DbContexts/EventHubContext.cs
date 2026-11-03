using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using G_NET69_EF_Assignment_2.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.IdentityModel.Tokens;

namespace G_NET69_EF_Assignment_2.DbContexts
{
    public class EventHubContext : DbContext
    {
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer(
                            "Server = DESKTOP-VGTVSKK;" +
                            "Database = EventHubDb;" +
                            "Trusted_Connection=True;" +
                            "TrustServerCertificate = True");
        }

        public DbSet<Organizer> Organizers { get; set; }
        public DbSet<OrganizerProfile> OrganizerProfiles { get; set; }
        public DbSet<Event> Events { get; set; }
        public DbSet<Attendee> Attendees { get; set; }
        public DbSet<Badge> Badges { get; set; }

    }
}
