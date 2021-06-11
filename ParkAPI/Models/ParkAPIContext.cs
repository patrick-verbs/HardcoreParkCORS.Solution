using Microsoft.EntityFrameworkCore;

namespace ParkAPI.Models
{
    public class ParkAPIContext : DbContext
    {
        public ParkAPIContext(DbContextOptions<ParkAPIContext> options)
            : base(options)
        {
        }

        protected override void OnModelCreating(ModelBuilder builder)
        {
            builder.Entity<Park>()
                .HasData(
                    new Park {
                        ParkId = 1,
                        Name = "Agate Beach",
                        Type = "State",
                        Location = "Near Newport, Oregon, United States",
                        Description = "(text courtesy of stateparks.oregon.gov) Diggers, this park's for you! Razor clamming is a favorite activity as well as surfing. If you plan to visit prime Newport attractions like the Oregon Coast Aquarium and Hatfield Marine Science Center, you must stop in for a refreshing picnic at Agate Beach.",
                        Url = "https://stateparks.oregon.gov/index.cfm?do=park.profile&parkId=152",
                        Phone = "541-265-4560"
                    }
                );
        }

        public DbSet<Park> Parks { get; set; }
    }
}