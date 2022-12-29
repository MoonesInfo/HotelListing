using AutoMapper;
using HotelListing.API.Contracts;
using HotelListing.API.Data;
using HotelListing.API.Models.Users;
using Microsoft.AspNetCore.Components.Forms;
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

        public async Task<IEnumerable<IdentityError>> Register(APIUserDto userDto)
        {
            var user = _mapper.Map<APIUser>(userDto);


            user.UserName = userDto.Email;
            var result = await _userManager.CreateAsync(user,userDto.Password);

            if (result.Succeeded)
            {
                await _userManager.AddToRoleAsync(user,"user");
            
            
            }
            return result.Errors;
        }
    }
}
