using AutoMapper;
using HotelListing.API.Contracts;
using HotelListing.API.Data;
using HotelListing.API.Models.Users;
using Microsoft.AspNetCore.Identity;

namespace HotelListing.API.Repository
{
    public class AuthManager : IAuthManager
    {
        private readonly Mapper _mapper;
        private readonly UserManager<APIUser> _userManager;

        public AuthManager(Mapper mapper,UserManager<APIUser> userManager)
        {
            this._mapper = mapper;
            this._userManager = userManager;
        }
        public Task<bool> Register(APIUserDto userDto)
        {
            throw new NotImplementedException();
        }
    }
}
