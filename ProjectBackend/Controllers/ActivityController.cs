using DotnetAuth.Infrastructure.Context;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using System.Security.Claims;

namespace ProjectBackend.Controllers
{
    [ApiController]
    [Route("api/activity")]
    [Authorize]
    public class ActivityController : ControllerBase
    {
        private readonly ApplicationDbContext _context;

        public ActivityController(ApplicationDbContext context)
        {
            _context = context;
        }

        [HttpGet]
        public IActionResult MyHistory()
        {
            var userId = User.FindFirstValue(ClaimTypes.NameIdentifier);

            if (string.IsNullOrEmpty(userId))
                return Unauthorized();

            var history = (
                from a in _context.UserActivities
                join m in _context.Movies on a.MovieId equals m.Id
                where a.UserId == userId
                orderby a.CreatedAt descending
                select new
                {
                    a.Id,
                    a.ActivityType,
                    a.CreatedAt,
                    MovieTitle = m.Title,
                    MoviePoster = m.PosterUrl
                }
            )
            .Take(30)
            .ToList();

            return Ok(history);
        }
    }
}
