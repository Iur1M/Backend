using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using ProjectBackend.Domain.Contracts;
using ProjectBackend.Service;

namespace ProjectBackend.Controllers
{
    [ApiController]
    [Route("api/auth")]
    public class AuthController : ControllerBase
    {
        private readonly IUserServices _userServices;

        public AuthController(IUserServices userServices)
        {
            _userServices = userServices;
        }

        [HttpPost("register")]
        [AllowAnonymous]
        public async Task<IActionResult> Register(UserRegisterRequest request)
        {
            return Ok(await _userServices.RegisterAsync(request));
        }

        [HttpPost("login")]
        [AllowAnonymous]
        public async Task<IActionResult> Login(UserLoginRequest request)
        {
            return Ok(await _userServices.LoginAsync(request));
        }

        [HttpPost("refresh")]
        [AllowAnonymous]
        public async Task<IActionResult> Refresh(RefreshTokenRequest request)
        {
            return Ok(await _userServices.RefreshTokenAsync(request));
        }

        [HttpPost("logout")]
        [Authorize]
        public async Task<IActionResult> Logout(RefreshTokenRequest request)
        {
            return Ok(await _userServices.RevokeRefreshToken(request));
        }
    }
}
