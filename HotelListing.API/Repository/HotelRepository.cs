using HotelListing.API.Contracts;
using HotelListing.API.Data;

namespace HotelListing.API.Repository
{
    public class HotelRepository : GenericRepository<Hotel>, IHotelsRespository
    {
        public HotelRepository(HotelListingDbContext context) : base(context)
        {
        }


    }
}
