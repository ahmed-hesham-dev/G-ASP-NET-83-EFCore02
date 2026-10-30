using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace G_ASP_NET_83_EFCore02.Context
{
    public class AppDbContext : DbContext               
    {
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer(
            "Server=localhost\\MSSQLSERVERR;Database=EventHub;Trusted_Connection=True;TrustServerCertificate=True;");
        }
       
        public AppDbContext(DbContextOptions<AppDbContext> options) : base(options)
        {  
        }



        public DbSet<Entities.Badge> Badges { get; set; }

        public DbSet<Entities.Organizer> Organizers { get; set; }

        public DbSet<Entities.OrganizerProfile> OrganizerProfiles { get; set; }

        public DbSet<Entities.Event> Events { get; set; }

        public DbSet<Entities.Attendee> Attendees { get; set; }
    }
}
