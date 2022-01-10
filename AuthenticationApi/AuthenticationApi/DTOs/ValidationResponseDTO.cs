using System.Collections.Generic;

namespace AuthenticationApi.DTOs
{
    public class ValidationResponseDTO
    {
        public string UserName { get; set; }

        public string Email { get; set; }

        public string Role { get; set; }
        
        
        public bool IsValidationSuccessful { get; set; }
    }
}