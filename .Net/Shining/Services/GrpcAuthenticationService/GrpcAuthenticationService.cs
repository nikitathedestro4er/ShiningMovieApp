using System.Threading.Tasks;
using AuthenticationApi;
using Grpc.Net.Client;

namespace Shining.Services.GrpcAuthenticationService
{
    public class GrpcAuthenticationService 
    {
        public async Task<ResultDTO> ValidateToken(string token)
        {
            using var channel = GrpcChannel.ForAddress("https://localhost:6000");

        
            var client = new Auth.AuthClient(channel);
        
        
            var reply = await client.ValidateTokenAsync(new TokenDTO { Token  = token});

            return reply;
        }
    }
}