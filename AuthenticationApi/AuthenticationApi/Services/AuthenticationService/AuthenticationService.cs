using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.IdentityModel.Tokens.Jwt;
using System.Linq;
using System.Security.Claims;
using System.Threading.Tasks;
using AuthenticationApi.DTOs;
using AuthenticationApi.Models;
using AuthenticationApi.Services.EmailService;
using AuthenticationApi.Services.TokenService;
using Microsoft.AspNetCore.Identity;
using System.Net;

namespace AuthenticationApi.Services.AuthenticationService
{
    public class AuthenticationService : IAuthenticationService
    {
        private readonly UserManager<User> _userManager;
        private readonly ITokenService _tokenService;
        private readonly IRabbitMQService _rabbitMqService;

        public AuthenticationService(UserManager<User> userManager, ITokenService tokenService, IRabbitMQService rabbitMqService)
        {
            _userManager = userManager;
            _tokenService = tokenService;
            _rabbitMqService = rabbitMqService;
        }

        public async Task<AuthResponseDTO> Login(UserForAuthenticationDTO userForAuthentication)
        {
            var user = await _userManager.FindByNameAsync(userForAuthentication.UserName);

            if (user == null || !await _userManager.CheckPasswordAsync(user, userForAuthentication.Password))
                return new AuthResponseDTO { IsAuthSuccessful = false, ErrorMessage = "Invalid Authentication" };

            var signingCredentials = _tokenService.GetSigningCredentials();
            var claims = await _tokenService.GetClaims(user);
            var tokenOptions = _tokenService.GenerateTokenOptions(signingCredentials, claims);
            var token = new JwtSecurityTokenHandler().WriteToken(tokenOptions);

            user.RefreshToken = _tokenService.GenerateRefreshToken();
            user.RefreshTokenExpiryTime = DateTime.Now.AddDays(7);

            await _userManager.UpdateAsync(user);

            return new AuthResponseDTO { IsAuthSuccessful = true, Token = token, RefreshToken = user.RefreshToken };
        }


        public async Task<RegistrationResponseDTO> Register(UserForRegistrationDTO userForRegistration)
        {
            var results = new List<ValidationResult>();
            var context = new ValidationContext(userForRegistration, null, null);
            var errors = new List<string>();
            if (!Validator.TryValidateObject(userForRegistration, context, results))
            {
                // results will contain all the failed validation errors.
                foreach (var error in results)
                {
                   errors.Add(error.ErrorMessage);
                }
            }

            if (userForRegistration is null || errors.Count > 0)
            {
                return new RegistrationResponseDTO { IsSuccessfulRegistration = false, Errors = errors };
            }
               
            var user = new User { UserName = userForRegistration.UserName, Email = userForRegistration.Email };

            var result = await _userManager.CreateAsync(user, userForRegistration.Password);
            if (!result.Succeeded)
            {
                var identityErrors = result.Errors.Select(e => e.Description);
                return new RegistrationResponseDTO { IsSuccessfulRegistration = false,Errors = identityErrors };
            }

            await _userManager.AddToRoleAsync(user, "User");

            return new RegistrationResponseDTO { IsSuccessfulRegistration = true, user = user };
        }



        public async Task<bool> ChangePassword(string userId, string token, string changePassword)
        {
            var user = await _userManager.FindByIdAsync(userId);

            if (user == null)
            {
               return false;
            }

            var decodedToken = WebUtility.HtmlDecode(token);
            
            var result = await _userManager.ResetPasswordAsync(user,decodedToken, changePassword);


            if (result.Succeeded)
            {
                return true;
            }
            else
            {
                return false;
            }
        }
        
        
        
        
        

        public async Task ResetPassword(string email)
        {
            var user = await _userManager.FindByEmailAsync(email);

            if (user == null)
            {
                return;
            }

            var token = await _userManager.GeneratePasswordResetTokenAsync(user);

            var link = $"http://localhost:3000/resetpassword/userId={WebUtility.UrlEncode(user.Id)}&token={WebUtility.UrlEncode(token)}";
            
            _rabbitMqService.Publish(new
            {
                Destination = email,
                Subject = "Reset Password",
                Body = "Hi, it's Shining MovieApp team, you had your password reset, if you didnt do it, just ignore this mail." +
                       "Best Regards! " +
                       $"Link to reset password :{link}"
            }, "demo.exchange.topic.dotnetcore","topic","*.queue.durable.dotnetcore.#");
        }



        public async Task<AuthResponseDTO> Refresh(RefreshTokenDTO refreshToken)
        {
            if (refreshToken is null)
            {
                return new AuthResponseDTO { IsAuthSuccessful = false, ErrorMessage = "Invalid client request" };
            }

            var principal = _tokenService.GetPrincipalFromExpiredToken(refreshToken.Token);
            var username = principal.Identity.Name;

            var user = await _userManager.FindByNameAsync(username);
            if (user == null || user.RefreshToken != refreshToken.RefreshToken || user.RefreshTokenExpiryTime <= DateTime.Now)
                return new AuthResponseDTO { IsAuthSuccessful = false, ErrorMessage = "Invalid client request" };

            var signingCredentials = _tokenService.GetSigningCredentials();
            var claims = await _tokenService.GetClaims(user);
            var tokenOptions = _tokenService.GenerateTokenOptions(signingCredentials, claims);
            var token = new JwtSecurityTokenHandler().WriteToken(tokenOptions);
            user.RefreshToken = _tokenService.GenerateRefreshToken();

            await _userManager.UpdateAsync(user);

            return new AuthResponseDTO { Token = token, RefreshToken = user.RefreshToken, IsAuthSuccessful = true };
        }

        
        
        public async Task<ValidationResponseDTO> Validate(string token)
        {
            var jwt = token.Replace("Bearer ", "");
            
            var principal = _tokenService.GetPrincipalFromToken(jwt);

            if (principal == null)
            {
                return new ValidationResponseDTO(){IsValidationSuccessful = false};
            }
            
            var username = principal.Identity.Name;

            var user = await _userManager.FindByNameAsync(username);

            var validationResponse = new ValidationResponseDTO() {UserName = user.UserName, Email = user.Email, IsValidationSuccessful = true};

            var roles = await _userManager.GetRolesAsync(user);

            validationResponse.Role = roles.First();
            
            return validationResponse;
        }
    }
}