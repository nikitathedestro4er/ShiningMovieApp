using System.Text.Json;
using System.Threading.Tasks;
using Grpc.Core;
using AuthenticationApi.Services.AuthenticationService;

namespace AuthenticationApi.Services.GrpcAuthenticationService
{
    public class GrpcAuthenticationService : Auth.AuthBase
    {
        private IAuthenticationService _authenticationService;
        
        public GrpcAuthenticationService(IAuthenticationService authenticationService)
        {
            _authenticationService = authenticationService;
        }
        public async override Task<ResultDTO> ValidateToken(TokenDTO request, ServerCallContext context)
        {
            var token = JsonSerializer.Deserialize<string>(request.Token);
            
            var result = await _authenticationService.Validate(token);
            
            return await Task.FromResult(new ResultDTO()
            {
                UserName = result?.UserName, Email = result?.Email, Role = result?.Role, IsValidationSuccess = result.IsValidationSuccessful
            });
        }
    }
}