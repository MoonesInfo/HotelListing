using HotelListing.API.Models.Users;
using Microsoft.AspNetCore.Components.Forms;
using Microsoft.AspNetCore.Identity;

namespace HotelListing.API.Contracts
{
    public interface IAuthManager
    {
        Task<IEnumerable<IdentityError>> Register(APIUserDto userDto);
        Task<AuthResponseDto> Login(LoginDto loginDto);


    }
}
