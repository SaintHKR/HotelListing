using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace HotelListing.Data
{
    public class DatabaseContext : DbContext
    {
        public DatabaseContext(DbContextOptions options) : base(options)
        {

        }

        public DbSet<Country> Countries { get; set; }

        public DbSet<Hotel> Hotels { get; set; }

        protected override void OnModelCreating(ModelBuilder builder)
        {
            builder.Entity<Country>().HasData(
                new Country
                {
                    CountryId = 1,
                    CountryName = "Jamaica",
                    CountryAbbreviation = "JM"
                },
                new Country
                {
                    CountryId = 2,
                    CountryName = "Bahamas",
                    CountryAbbreviation = "BS"
                },
                new Country
                {
                    CountryId = 3,
                    CountryName = "Cayman Island",
                    CountryAbbreviation = "CI"
                }
                );

            builder.Entity<Hotel>().HasData(
                new Hotel
                {
                    HotelId = 1,
                    HotelName = "Sandals Resort and Spa",
                    HotelAddress ="Negril",
                    HotelRating = 4.5,
                    CountryId = 1 
                },
                new Hotel
                {
                    HotelId = 2,
                    HotelName = "Grand Palldium",
                    HotelAddress = "Nassua",
                    HotelRating = 4,
                    CountryId = 2
                },
                new Hotel
                {
                    HotelId = 3,
                    HotelName = "Comfort Suites",
                    HotelAddress = "George Town",
                    HotelRating = 4.3,
                    CountryId = 3
                }
                );
        }

    }
}

 
