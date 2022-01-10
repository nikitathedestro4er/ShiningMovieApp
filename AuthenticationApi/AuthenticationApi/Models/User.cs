using System;
using Microsoft.AspNetCore.Identity;

namespace AuthenticationApi.Models
{
    public class User : IdentityUser
    {
        public string RefreshToken { get; set; }
        public DateTime RefreshTokenExpiryTime { get; set; }
    }
}