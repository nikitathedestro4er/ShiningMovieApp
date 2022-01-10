using System.Collections.Generic;
using System.Security.Claims;
using System.Threading.Tasks;
using AuthenticationApi.DTOs;

namespace AuthenticationApi.Services.AuthenticationService
{
    public interface IAuthenticationService
    {
        Task<RegistrationResponseDTO> Register(UserForRegistrationDTO userForRegistration);

        Task<AuthResponseDTO> Login(UserForAuthenticationDTO userForAuthentication);


        Task<bool> ChangePassword(string userId, string token, string changePassword);
        
        Task ResetPassword(string email);
        
        Task<AuthResponseDTO> Refresh(RefreshTokenDTO refreshToken);

        Task<ValidationResponseDTO> Validate(string token);
    }
}