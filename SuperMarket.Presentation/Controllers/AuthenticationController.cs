using Microsoft.AspNetCore.Mvc;
using Service.Contracts;
using Shared.DTO;

namespace SuperMarket.Presentation.Controllers
{
    [Route("api/authentication")]
    [ApiController]
    public class AuthenticationController : ControllerBase
    {
        private IServiceManager _service;

        public AuthenticationController(IServiceManager service) => _service = service;

        [Route("RegisterUser")]
        [HttpPost]
        public async Task<IActionResult> RegisterUser([FromBody] UserForRegistrationDto
            userForRegistration)
        {
            var result = await  _service.Authentication.RegisterUser(userForRegistration);
            if (!result.Succeeded)
            {
                foreach (var error in result.Errors)
                {
                    ModelState.TryAddModelError(error.Code, error.Description);
                }
                return BadRequest(ModelState);
            }
            return StatusCode(201);
        }

        [HttpPost("login")]
        public async Task<IActionResult> Authenticate([FromBody] UserForAuthenticationDto user)
        {
            if (!await _service.Authentication.ValidateUser(user))
                return Unauthorized();

            var tokenDto = await _service.Authentication
            .CreateToken(populateExp: true);

            return Ok(tokenDto);
        }
    }
}
