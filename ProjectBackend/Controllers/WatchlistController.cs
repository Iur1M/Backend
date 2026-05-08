using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using System.Security.Claims;
using DotnetAuth.Infrastructure.Context;
using ProjectBackend.Domain.Entities;

namespace ProjectBackend.Controllers
{
    [Authorize]
    [ApiController]
    [Route("api/[controller]")]
    public class WatchlistController : ControllerBase
    {
        private readonly ApplicationDbContext _context;

        public WatchlistController(ApplicationDbContext context)
        {
            _context = context;
        }

        [HttpGet]
        public async Task<IActionResult> GetMyWatchlist()
        {
            var userId = User.FindFirst(ClaimTypes.NameIdentifier)?.Value;

            var movies = await _context.WatchlistItems
                .Where(x => x.UserId == userId)
                .Include(x => x.Movie)
                .Select(x => x.Movie)
                .ToListAsync();

            return Ok(movies);
        }

        [HttpPost("{movieId}")]
        public async Task<IActionResult> ToggleWatchlist(int movieId)
        {
            var userId = User.FindFirst(ClaimTypes.NameIdentifier)?.Value;
            if (string.IsNullOrEmpty(userId)) return Unauthorized();

            var existing = await _context.WatchlistItems
                .FirstOrDefaultAsync(x => x.UserId == userId && x.MovieId == movieId);

            if (existing != null)
            {
                _context.WatchlistItems.Remove(existing);
                await _context.SaveChangesAsync();
                return Ok(new { added = false });
            }

            _context.WatchlistItems.Add(new WatchlistItem { UserId = userId, MovieId = movieId });
            await _context.SaveChangesAsync();
            return Ok(new { added = true });
        }
    }
}