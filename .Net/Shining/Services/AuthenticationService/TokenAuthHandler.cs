using System.Net.Http;
using System.Security.Claims;
using System.Text;
using System.Text.Encodings.Web;
using System.Text.Json;
using System.Threading.Tasks;
using AuthenticationApi;
using Microsoft.AspNetCore.Authentication;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.Logging;
using Microsoft.Extensions.Options;
using Microsoft.Net.Http.Headers;

namespace Shining.Services.AuthenticationService
{
    public class TokenAuthHandler : AuthenticationHandler<TokenAuthSchemeOptions>
    {

        public TokenAuthHandler(IConfiguration configuration, IOptionsMonitor<TokenAuthSchemeOptions> options,
            ILoggerFactory logger, UrlEncoder encoder, ISystemClock clock) : base(options, logger, encoder, clock)
        {
            
            _validationURl = configuration.GetValue<string>("ValidationUrl");
        }
        
        private string _validationURl;
        
        protected override async Task<AuthenticateResult> HandleAuthenticateAsync()
        {
            if (!Request.Headers.ContainsKey(HeaderNames.Authorization))
            {
                return await Task.FromResult(AuthenticateResult.NoResult());
            }
            
            var token = Request.Headers[HeaderNames.Authorization].ToString();

            var json = JsonSerializer.Serialize(token);

            /*var data = new StringContent(json, Encoding.UTF8, "application/json");

            var client = new HttpClient();

            var response = await client.PostAsync(_validationURl, data);

            var content = await response.Content.ReadAsStringAsync();*/

            var service = new GrpcAuthenticationService.GrpcAuthenticationService();
            
            var result = await service.ValidateToken(json);
            
            //var validationResponse = JsonSerializer.Deserialize<ValidationResponseDTO>(content, new JsonSerializerOptions { PropertyNameCaseInsensitive = true });
            
            
            if (!result.IsValidationSuccess)
            {
                return await Task.FromResult(AuthenticateResult.Fail("Token invalid"));
            }
            
            
            var claims = new []
            {
                new Claim(ClaimTypes.Name, result.UserName),
                new Claim(ClaimTypes.Email, result.Email),
                new Claim(ClaimTypes.Role, result.Role)
            };
            

            var identity = new ClaimsIdentity(claims);

            var principal = new ClaimsPrincipal(identity);

            var ticket = new AuthenticationTicket(principal, Scheme.Name);

            return AuthenticateResult.Success(ticket);
            

        }
    }
}