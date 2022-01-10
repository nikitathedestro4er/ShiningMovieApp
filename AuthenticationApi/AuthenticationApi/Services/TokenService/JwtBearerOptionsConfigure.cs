using System;
using System.Text;
using Microsoft.AspNetCore.Authentication.JwtBearer;
using Microsoft.Extensions.Options;
using Microsoft.IdentityModel.Tokens;

namespace AuthenticationApi.Services.TokenService
{
    public class JwtBearerOptionsConfigure : IPostConfigureOptions<JwtBearerOptions>
    {
        IOptions<TokenSettings> _tokenSettings;

        public JwtBearerOptionsConfigure(IOptions<TokenSettings> tokenSettings)
        {
            _tokenSettings = tokenSettings;
        }

        public void PostConfigure(string name, JwtBearerOptions options)
        {
            options.TokenValidationParameters = new TokenValidationParameters
            {
                ValidateIssuer = true,
                ValidateAudience = true,
                ValidateLifetime = true,
                ValidateIssuerSigningKey = true,
                IssuerSigningKey = new SymmetricSecurityKey(Encoding.UTF8.GetBytes(_tokenSettings.Value.SecurityKey)),
                ClockSkew = TimeSpan.Zero,
                ValidAudience = _tokenSettings.Value.ValidAudience,
                ValidIssuer = _tokenSettings.Value.ValidIssuer
            };
        }
    }
}