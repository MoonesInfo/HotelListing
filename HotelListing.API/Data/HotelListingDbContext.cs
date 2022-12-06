using Microsoft.EntityFrameworkCore;
using Microsoft.Identity.Client;

namespace HotelListing.API.Data
{
    public class HotelListingDbContext:DbContext
    {
        public HotelListingDbContext(DbContextOptions options) : base(options)
        { 
        
        
        }

        public DbSet<Hotel> Hotels { get; set; }
        public DbSet<Country> Countries { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {


            base.OnModelCreating(modelBuilder);

            modelBuilder.Entity<Country>().HasData(
                new Country
                { 
                Id=1,Name="Jamaica",ShortName="JM"
                },
                new Country
                {
                    Id = 2,
                    Name = "Iran",
                    ShortName = "IR"
                },
                new Country
                {
                    Id = 3,
                    Name = "United States",
                    ShortName = "US"
                }
                );


            modelBuilder.Entity<Hotel>().HasData(

                new Hotel
                {
                    Id = 1,
                    Name="Sandals",
                    Address="Negril",
                    CountryId=1,
                    Rating=4.5
                },
                 new Hotel
                 {
                     Id = 2,
                     Name = "Comfort",
                     Address = "Katy",
                     CountryId = 3,
                     Rating = 4.3
                 },
                  new Hotel
                  {
                      Id = 3,
                      Name = "Ana",
                      Address = "Urmia",
                      CountryId = 2,
                      Rating = 4
                  }


                ); ;
        }
    }
}
