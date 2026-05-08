using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using ProjectBackend.Domain.Contracts;
using ProjectBackend.Service;

namespace ProjectBackend.Controllers
{
    [ApiController]
    [Route("api/users")]
    [Authorize]
    public class UserController : ControllerBase
    {
        private readonly IUserServices _userServices;

        public UserController(IUserServices userServices)
        {
            _userServices = userServices;
        }

        [HttpGet("me")]
        public async Task<IActionResult> Me()
        {
            return Ok(await _userServices.GetCurrentUserAsync());
        }

        [Authorize(Roles = "Admin")]
        [HttpGet("all")]
        public async Task<IActionResult> GetAllUsers()
        {
            return Ok(await _userServices.GetAllAsync());
        }

        [Authorize(Roles = "Admin")]
        [HttpDelete("{id}")]
        public async Task<IActionResult> Delete(Guid id)
        {
            await _userServices.DeleteAsync(id);
            return NoContent();
        }

        [HttpPatch("favorite-movie/{movieId}")]
        public async Task<IActionResult> SetFavoriteMovie(int movieId)
        {
            await _userServices.UpdateFavoriteMovieAsync(movieId);
            return NoContent();
        }
    }
}
