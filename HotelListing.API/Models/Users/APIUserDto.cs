using System.ComponentModel.DataAnnotations;

namespace HotelListing.API.Models.Users
{
    public class APIUserDto
    {
        [Required]
        public string FirstName { get; set; }
        [Required]
        public string LastName { get; set; }
        [Required]
        [EmailAddress]
        public string Email { get; set; }
        [Required]
        [StringLength(15,ErrorMessage ="Wrong!",MinimumLength =3)]
        public string Password { get; set; }
    }
}

