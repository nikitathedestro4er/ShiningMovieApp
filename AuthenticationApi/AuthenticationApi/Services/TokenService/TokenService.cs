using System;
using System.Collections.Generic;
using System.IdentityModel.Tokens.Jwt;
using System.Security.Claims;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using AuthenticationApi.Models;
using Microsoft.AspNetCore.Identity;
using Microsoft.Extensions.Options;
using Microsoft.IdentityModel.Tokens;

namespace AuthenticationApi.Services.TokenService
{
    public class TokenService : ITokenService
    {
        private readonly UserManager<User> _userManager;
        private readonly IOptions<TokenSettings> _tokenSettings;

        public TokenService(UserManager<User> userManager, IOptions<TokenSettings> tokenSettings)
        {
            _userManager = userManager;
            _tokenSettings = tokenSettings;
        }


        public SigningCredentials GetSigningCredentials()
        {
            var key = Encoding.UTF8.GetBytes(_tokenSettings.Value.SecurityKey);
            var secret = new SymmetricSecurityKey(key);

            return new SigningCredentials(secret, SecurityAlgorithms.HmacSha256);
        }

        public async Task<List<Claim>> GetClaims(User user)
        {
            var claims = new List<Claim>
            {
                new Claim(ClaimTypes.Name, user.UserName),
                new Claim(ClaimTypes.Email, user.Email),
                new Claim(ClaimTypes.NameIdentifier, user.Id)
            };

            var roles = await _userManager.GetRolesAsync(user);
            foreach (var role in roles)
            {
                claims.Add(new Claim(ClaimTypes.Role, role));
            }
            return claims;
        }

        public JwtSecurityToken GenerateTokenOptions(SigningCredentials signingCredentials, List<Claim> claims)
        {
            var tokenOptions = new JwtSecurityToken(
                issuer: _tokenSettings.Value.ValidIssuer,
                audience: _tokenSettings.Value.ValidAudience,
                claims: claims,
                expires: DateTime.Now.AddMinutes(Convert.ToDouble(_tokenSettings.Value.ExpiryInMinutes)),
                signingCredentials: signingCredentials);

            return tokenOptions;
        }

        public string GenerateRefreshToken()
        {
            var randomNumber = new byte[32];
            using (var rng = RandomNumberGenerator.Create())
            {
                rng.GetBytes(randomNumber);
                return Convert.ToBase64String(randomNumber);
            }
        }

        public ClaimsPrincipal GetPrincipalFromExpiredToken(string token)
        {
            var tokenValidationParameters = GetValidationParameters(false);

            var tokenHandler = new JwtSecurityTokenHandler();
            SecurityToken securityToken;
            var principal = tokenHandler.ValidateToken(token, tokenValidationParameters, out securityToken);

            var jwtSecurityToken = securityToken as JwtSecurityToken;
            if (jwtSecurityToken == null || !jwtSecurityToken.Header.Alg.Equals(SecurityAlgorithms.HmacSha256,
                StringComparison.InvariantCultureIgnoreCase))
            {
                throw new SecurityTokenException("Invalid token");
            }

            return principal;
        }
        
        
        
        
        public ClaimsPrincipal GetPrincipalFromToken(string token)
        {
            var tokenValidationParameters = GetValidationParameters(true);

            var tokenHandler = new JwtSecurityTokenHandler();
            SecurityToken securityToken;
            
            try
            {
                var principal = tokenHandler.ValidateToken(token, tokenValidationParameters, out securityToken);
                return principal;
            }
            catch(SecurityTokenExpiredException)
            {
                return null;
            }

        }
        
        
        
        private TokenValidationParameters GetValidationParameters(bool checkExpire)
        {
            return new TokenValidationParameters()
            {
                ValidateAudience = true,
                ValidateIssuer = true,
                ValidateIssuerSigningKey = true,
                IssuerSigningKey = new SymmetricSecurityKey(
                    Encoding.UTF8.GetBytes(_tokenSettings.Value.SecurityKey)),
                ClockSkew = TimeSpan.Zero,
                ValidateLifetime = checkExpire,
                ValidIssuer = _tokenSettings.Value.ValidIssuer,
                ValidAudience = _tokenSettings.Value.ValidAudience
            };
        }


        

        
    }
}