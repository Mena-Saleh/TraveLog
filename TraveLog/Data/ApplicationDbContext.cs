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
                new Country { Id = 3, Name = "India" },
                new Country { Id = 4, Name = "Japan" },
                new Country { Id = 5, Name = "Brazil" },
                new Country { Id = 6, Name = "Australia" }
            );

            // Seeding initial data for destinations
            modelBuilder.Entity<Destination>().HasData(
                // Destinations in Egypt
                new Destination { Id = 1, Name = "Pyramids", Description = "The Great Pyramids of Giza, a wonder of ancient world.", CountryId = 1, ImageUrl = "Pyramids.jpg" },
                new Destination { Id = 2, Name = "Karnak Temple", Description = "A large temple complex in Luxor, dedicated to Amun-Ra.", CountryId = 1, ImageUrl = "Karnak Temple.jpg" },
                new Destination { Id = 3, Name = "Hatshepsut Temple", Description = "The mortuary temple of Hatshepsut, located in Deir el-Bahari.", CountryId = 1, ImageUrl = "Hatshepsut Temple.jpg" },
                new Destination { Id = 4, Name = "Valley of the Kings", Description = "A valley in Luxor where tombs were constructed for the Pharaohs.", CountryId = 1, ImageUrl = "Valley of the Kings.jpg" },
                new Destination { Id = 5, Name = "Abu Simbel Temples", Description = "Massive rock temples at Abu Simbel, built by Ramses II.", CountryId = 1, ImageUrl = "Abu Simbel Temples.jpg" },

                // Destinations in Sweden
                new Destination { Id = 6, Name = "Vasa Museum", Description = "A maritime museum in Stockholm, home to the 17th-century ship Vasa.", CountryId = 2, ImageUrl = "Vasa Museum.jpg" },
                new Destination { Id = 7, Name = "Kalmar Castle", Description = "A medieval castle in Kalmar, with a history dating back to 12th century.", CountryId = 2, ImageUrl = "Kalmar Castle.jpg" },
                new Destination { Id = 8, Name = "Gamla Stan", Description = "The old town of Stockholm, known for its cobblestone streets and colorful buildings.", CountryId = 2, ImageUrl = "Gamla Stan.jpg" },
                new Destination { Id = 9, Name = "Drottningholm Palace", Description = "A royal palace in Stockholm, the private residence of the Swedish royal family.", CountryId = 2, ImageUrl = "Drottningholm Palace.jpg" },

                // Destinations in India
                new Destination { Id = 10, Name = "Amber Palace", Description = "A palace in Jaipur, known for its artistic Hindu-style elements.", CountryId = 3, ImageUrl = "Amber Palace.jpg" },
                new Destination { Id = 11, Name = "Taj Mahal", Description = "A mausoleum in Agra, built by Emperor Shah Jahan.", CountryId = 3, ImageUrl = "Taj Mahal.jpg" },
                new Destination { Id = 12, Name = "Qutub Minar", Description = "A minaret and victory tower in Delhi, one of the tallest in India.", CountryId = 3, ImageUrl = "Qutub Minar.jpg" },
                new Destination { Id = 13, Name = "Mysore Palace", Description = "A historical palace in the city of Mysore, known for its architectural grandeur.", CountryId = 3, ImageUrl = "Mysore Palace.jpg" },

                // Destinations in Japan
                new Destination { Id = 14, Name = "Mount Fuji", Description = "An iconic volcano and the highest peak in Japan, a popular climbing spot.", CountryId = 4, ImageUrl = "Mount Fuji.jpg" },
                new Destination { Id = 15, Name = "Kinkaku-ji", Description = "The Golden Pavilion, a Zen Buddhist temple in Kyoto.", CountryId = 4, ImageUrl = "Kinkakuji.jpg" },
                new Destination { Id = 16, Name = "Tokyo Tower", Description = "A communications and observation tower in Tokyo, inspired by the Eiffel Tower.", CountryId = 4, ImageUrl = "Tokyo Tower.jpg" },

                // Destinations in Brazil
                new Destination { Id = 17, Name = "Christ the Redeemer", Description = "An iconic statue of Jesus Christ in Rio de Janeiro.", CountryId = 5, ImageUrl = "Christ the Redeemer.jpg" },
                new Destination { Id = 18, Name = "Iguazu Falls", Description = "A massive waterfall system on the border of Brazil and Argentina.", CountryId = 5, ImageUrl = "Iguazu Falls.jpg" },
                new Destination { Id = 19, Name = "Sugarloaf Mountain", Description = "A peak situated in Rio de Janeiro, offering panoramic views.", CountryId = 5, ImageUrl = "Sugarloaf Mountain.jpg" },

                // Destinations in Australia
                new Destination { Id = 20, Name = "Sydney Opera House", Description = "An iconic performing arts center in Sydney, known for its unique design.", CountryId = 6, ImageUrl = "Sydney Opera House.jpg" },
                new Destination { Id = 21, Name = "Great Barrier Reef", Description = "The world's largest coral reef system, located in the Coral Sea.", CountryId = 6, ImageUrl = "Great Barrier Reef.jpg" },
                new Destination { Id = 22, Name = "Uluru", Description = "A massive sandstone monolith in the heart of the Northern Territory.", CountryId = 6, ImageUrl = "Uluru.jpg" }
            );
        }

    }


}
