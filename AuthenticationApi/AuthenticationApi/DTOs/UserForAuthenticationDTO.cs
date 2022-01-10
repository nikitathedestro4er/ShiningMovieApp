using System.ComponentModel.DataAnnotations;

namespace AuthenticationApi.DTOs
{
    public class UserForAuthenticationDTO
    {
        [Required(ErrorMessage = "Username is required.")]
        public string UserName { get; set; }
        [Required(ErrorMessage = "Password is requiered.")]
        public string Password { get; set; }
    }
}