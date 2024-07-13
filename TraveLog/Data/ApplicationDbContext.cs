using TraveLog.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.AspNetCore.Identity;

namespace TraveLog.Data
{
    public class ApplicationDbContext : IdentityDbContext<ApplicationUser>
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options) : base(options)
        {

        }

        public DbSet<Country> Countries { get; set; }
        public DbSet<Destination> Destinations { get; set; }
        public DbSet<ApplicationUser> ApplicationUsers { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);

            // Seeding initial data for countries
            modelBuilder.Entity<Country>().HasData(
                new Country { Id = 1, Name = "Egypt" },
                new Country { Id = 2, Name = "Sweden" },
                new Country { Id = 3, Name = "India" }
            );

            // Seeding initial data for destinations
            modelBuilder.Entity<Destination>().HasData(
                // Destinations in Egypt
                new Destination { Id = 1, Name = "Pyramids", Description = "The Great Pyramids of Giza", CountryId = 1, ImageUrl = "Pyramids.jpg" },
                new Destination { Id = 2, Name = "Karnak Temple", Description = "A large temple complex in Luxor", CountryId = 1, ImageUrl = "Karnak Temple.jpg" },
                new Destination { Id = 3, Name = "Hatshepsut Temple", Description = "The mortuary temple of Hatshepsut", CountryId = 1, ImageUrl = "Hatshepsut Temple.jpg" },

                // Destinations in Sweden
                new Destination { Id = 4, Name = "Vasa Museum", Description = "A maritime museum in Stockholm", CountryId = 2, ImageUrl = "Vasa Museum.jpg" },
                new Destination { Id = 5, Name = "Kalmar Castle", Description = "A medieval castle in Kalmar", CountryId = 2, ImageUrl = "Kalmar Castle.jpg" },

                // Destinations in India
                new Destination { Id = 6, Name = "Amber Palace", Description = "A palace in Jaipur", CountryId = 3, ImageUrl = "Amber Palace.jpg" },
                new Destination { Id = 7, Name = "Taj Mahal", Description = "A mausoleum in Agra", CountryId = 3, ImageUrl = "Taj Mahal.jpg" }
            );
        }

    }


}
