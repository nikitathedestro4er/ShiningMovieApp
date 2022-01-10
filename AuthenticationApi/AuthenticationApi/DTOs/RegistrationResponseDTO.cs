using System.Collections.Generic;
using AuthenticationApi.Models;

namespace AuthenticationApi.DTOs
{
    public class RegistrationResponseDTO
    {
        public bool IsSuccessfulRegistration { get; set; }
        public IEnumerable<string> Errors { get; set; }
        public User user { get; set; }
    }
}