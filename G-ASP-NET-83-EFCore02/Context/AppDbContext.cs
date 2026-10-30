
using G_ASP_NET_83_EFCore02.Entities;
using Microsoft.EntityFrameworkCore;

namespace G_ASP_NET_83_EFCore02.Context
{
    public class AppDbContext : DbContext
    {
        public AppDbContext(DbContextOptions<AppDbContext> options)
            : base(options)
        {
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);

            modelBuilder.Entity<OrganizerProfile>(entity =>
            {
                entity.HasKey(p => p.Id);
            });

            modelBuilder.Entity<Organizer>()
                .HasOne(o => o.Profile)
                .WithOne(p => p.Organizer)
                .HasForeignKey<OrganizerProfile>(p => p.OrganizerId);

            modelBuilder.ApplyConfigurationsFromAssembly(
                typeof(AppDbContext).Assembly
            );
        }

        protected override void OnConfiguring(
            DbContextOptionsBuilder optionsBuilder)
        {
            if (!optionsBuilder.IsConfigured)
            {
                optionsBuilder.UseSqlServer(
                    "Server=localhost\\MSSQLSERVERR;Database=EventHub;Trusted_Connection=True;TrustServerCertificate=True;"
                );
            }
        }

        #region DbSet Properties

        public DbSet<Badge> Badges { get; set; }
        public DbSet<Organizer> Organizers { get; set; }
        public DbSet<OrganizerProfile> OrganizerProfiles { get; set; }
        public DbSet<Event> Events { get; set; }
        public DbSet<Attendee> Attendees { get; set; }

        #endregion
    }
}
