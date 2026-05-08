using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using ProjectBackend.Domain.Contracts;
using ProjectBackend.Service;
using DotnetAuth.Infrastructure.Context;
using ProjectBackend.Domain.Entities;
using System.Security.Claims;
using Microsoft.EntityFrameworkCore;

namespace ProjectBackend.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class MovieController : ControllerBase
    {
        private readonly IMovieService _movieService;
        private readonly ApplicationDbContext _context;

        public MovieController(
            IMovieService movieService,
            ApplicationDbContext context)
        {
            _movieService = movieService;
            _context = context;
        }

        [HttpGet]
        [AllowAnonymous]
        public async Task<IActionResult> GetMovies(
            string? search,
            string? director,
            int? year,
            double? minRating,
            double? maxRating,
            string? genre,
            string? sortBy,
            bool desc = false,
            int page = 1,
            int pageSize = 50)
        {
            var result = await _movieService.GetMovies(
                search,
                director,
                year,
                minRating,
                maxRating,
                genre,
                sortBy,
                desc,
                page,
                pageSize);

            return Ok(result);
        }

        [HttpGet("{id:int}")]
        [AllowAnonymous]
        public async Task<IActionResult> GetMovieById(int id)
        {
            var movie = await _movieService.GetMovieByIdAsync(id);

            if (movie == null)
                return NotFound();

            var userId = User.FindFirstValue(ClaimTypes.NameIdentifier);
            if (userId != null)
            {
                _context.UserActivities.Add(new UserActivity
                {
                    UserId = userId,
                    MovieId = id,
                    ActivityType = "View"
                });

                await _context.SaveChangesAsync();
            }

            return Ok(movie);
        }


        [HttpGet("years")]
        [AllowAnonymous]
        public async Task<IActionResult> GetYears()
        {
            var years = await _context.Movies
                .Select(m => m.Year)
                .Distinct()
                .OrderByDescending(y => y)
                .ToListAsync();

            return Ok(years);
        }

        [HttpGet("genres")]
        [AllowAnonymous]
        public async Task<IActionResult> GetGenres()
        {
            var genres = await _context.Movies
                .Where(m => !string.IsNullOrEmpty(m.Genre))
                .Select(m => m.Genre)
                .Distinct()
                .OrderBy(g => g)
                .ToListAsync();

            return Ok(genres);
        }


        [HttpPost]
        [Authorize(Roles = "Admin")]
        public async Task<IActionResult> AddMovie([FromBody] AddMovieDto dto)
        {
            var movie = await _movieService.AddMovieAsync(dto);
            return Ok(movie);
        }

        [HttpDelete("{id:int}")]
        [Authorize(Roles = "Admin")]
        public async Task<IActionResult> DeleteMovie(int id)
        {
            var deleted = await _movieService.DeleteMovieAsync(id);

            if (!deleted)
                return NotFound();

            return NoContent();
        }

        [HttpPut("{id:int}")]
        [Authorize(Roles = "Admin")]
        public async Task<IActionResult> UpdateMovie(int id, [FromBody] AddMovieDto dto)
        {
            var updated = await _movieService.UpdateMovieAsync(id, dto);
            return Ok(updated);
        }

        [HttpGet("directors")]
        [Authorize(Roles = "Admin")]
        public async Task<IActionResult> GetDirectors()
        {
            var directors = await _context.Movies
                .Select(m => m.Director)
                .Distinct()
                .OrderBy(d => d)
                .ToListAsync();

            return Ok(directors);
        }

        [HttpPost("upload")]
        [Authorize(Roles = "Admin")]
        public async Task<IActionResult> AddMovieWithImage([FromForm] AddMovieDto dto, IFormFile file)
        {
            if (file == null || file.Length == 0)
                return BadRequest("File is required");

            var fileName = Guid.NewGuid() + Path.GetExtension(file.FileName);
            var folderPath = Path.Combine(Directory.GetCurrentDirectory(), "wwwroot/images");

            if (!Directory.Exists(folderPath))
                Directory.CreateDirectory(folderPath);

            var filePath = Path.Combine(folderPath, fileName);

            using (var stream = new FileStream(filePath, FileMode.Create))
            {
                await file.CopyToAsync(stream);
            }

            dto.PosterUrl = $"https://localhost:7220/images/{fileName}";

            var movie = await _movieService.AddMovieAsync(dto);

            return Ok(movie);
        }
    }
}