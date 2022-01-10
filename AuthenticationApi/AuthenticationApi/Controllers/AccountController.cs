using System.Threading.Tasks;
using AuthenticationApi.DTOs;
using AuthenticationApi.Services.AuthenticationService;
using Microsoft.AspNetCore.Mvc;

namespace AuthenticationApi.Controllers
{
    [ApiController]
    [Route("api/account")]
    public class AccountController : ControllerBase
    {
        private readonly IAuthenticationService _authenticationService;
        

        public AccountController(IAuthenticationService authenticationService)
        {
            _authenticationService = authenticationService;
        }

        [HttpPost("Registration")]
        public async Task<IActionResult> Register([FromBody] UserForRegistrationDTO userForRegistration)
        {
            RegistrationResponseDTO registrationResponse = await _authenticationService.Register(userForRegistration);

            if (!registrationResponse.IsSuccessfulRegistration)
            {
                return BadRequest(registrationResponse);
            }

            return Created("",registrationResponse.user);
            
        }

        [HttpPost("Login")]
        public async Task<IActionResult> Login([FromBody] UserForAuthenticationDTO userForAuthentication)
        {

            AuthResponseDTO authResponse = await _authenticationService.Login(userForAuthentication);

            if (!authResponse.IsAuthSuccessful)
            {
                return BadRequest(authResponse);
            }
           
            return Ok(authResponse);
        }

        
        [HttpPost("ChangePassword")]
        public async Task<IActionResult> ChangePassword([FromQuery] string userId, [FromQuery] string token ,[FromBody] string password)
        {
            var result= await _authenticationService.ChangePassword(userId, token, password);

            if (result == false)
            {
                return BadRequest();
            }
            
            return Ok();
        }
        
        
        
        [HttpPost("ResetPassword")]
        public async Task<IActionResult> ResetPassword([FromBody] string email)
        {
            await _authenticationService.ResetPassword(email);
            
            return Ok();
        }
        

        [HttpPost]
        [Route("Refresh")]
        public async Task<IActionResult> Refresh([FromBody] RefreshTokenDTO tokenDto)
        {
            AuthResponseDTO authResponse = await _authenticationService.Refresh(tokenDto);

            if (!authResponse.IsAuthSuccessful)
            {
                return BadRequest(authResponse);
            }

            return Ok(authResponse);

        }
        
        
        
        [HttpPost]
        [Route("Validate")]
        public async Task<IActionResult> Validate([FromBody] string token)
        {
            
            var claims = await _authenticationService.Validate(token);
            
            return Ok(claims);

        }


    }

}