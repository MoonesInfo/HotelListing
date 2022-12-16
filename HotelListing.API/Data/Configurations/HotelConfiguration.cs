using Microsoft.AspNetCore.Identity;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace HotelListing.API.Data.Configurations
{
    public class HotelConfiguration : IEntityTypeConfiguration<Hotel>
    {
        public void Configure(EntityTypeBuilder<Hotel> builder)
        {
            builder.HasData(

                new Hotel
                {
                    Id = 1,
                    Name = "Sandals",
                    Address = "Negril",
                    CountryId = 1,
                    Rating = 4.5
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


                );
        }
    }
}
