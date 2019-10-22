using System.ComponentModel.DataAnnotations;

namespace FlyApp.API.Dtos
{
    public class UserForRegisterDto
    {
        [Required]
        public string Username { get; set; }

        [Required]
        [StringLength(24, MinimumLength=4, ErrorMessage="Password must be between 4 and 24 characters")]
        public string Password { get; set; }

        [Required]
        public string PreferedName { get; set; }
    }
}