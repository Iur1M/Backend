using DotnetAuth.Infrastructure.Context;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using ProjectBackend.Domain.Contracts;
using ProjectBackend.Domain.Entities;
using ProjectBackend.Domain.Entities.ProjectBackend.Domain.Entities;
using System.Security.Claims;

namespace ProjectBackend.Controllers
{
    [ApiController]
    [Route("api/comments")]
    public class CommentController : ControllerBase
    {
        private readonly ApplicationDbContext _context;

        public CommentController(ApplicationDbContext context)
        {
            _context = context;
        }

        [HttpGet("{movieId}")]
        public IActionResult GetByMovie(int movieId)
        {
            var comments = _context.Comments
                .Where(c => c.MovieId == movieId)
                .OrderByDescending(c => c.CreatedAt)
                .ToList();

            return Ok(comments);
        }

        [Authorize]
        [HttpPost]
        public IActionResult Create(CreateCommentDto dto)
        {
            var userId = User.FindFirstValue(ClaimTypes.NameIdentifier);

            var firstName = User.FindFirstValue("FirstName");
            var lastName = User.FindFirstValue("LastName");

            var userName = $"{firstName} {lastName}".Trim();
            if (string.IsNullOrWhiteSpace(userName))
                userName = "User";

            var comment = new Comment
            {
                MovieId = dto.MovieId,
                Text = dto.Text,
                Rating = dto.Rating,
                UserId = userId,
                UserName = userName
            };

            _context.Comments.Add(comment);

            _context.UserActivities.Add(new UserActivity
            {
                UserId = userId,
                MovieId = dto.MovieId,
                ActivityType = "Comment"
            });

            _context.SaveChanges();

            return Ok(comment);
        }

        [Authorize]
        [HttpPut("{id}")]
        public IActionResult Update(int id, UpdateCommentDto dto)
        {
            var comment = _context.Comments.FirstOrDefault(c => c.Id == id);
            if (comment == null) return NotFound();

            if (comment.UserId != User.FindFirstValue(ClaimTypes.NameIdentifier))
                return Forbid();

            comment.Text = dto.Text;
            comment.Rating = dto.Rating;

            _context.SaveChanges();
            return Ok(comment);
        }

        [Authorize]
        [HttpDelete("{id}")]
        public IActionResult Delete(int id)
        {
            var comment = _context.Comments.FirstOrDefault(c => c.Id == id);
            if (comment == null) return NotFound();

            var isAdmin = User.IsInRole("Admin");
            var isOwner = comment.UserId == User.FindFirstValue(ClaimTypes.NameIdentifier);

            if (!isAdmin && !isOwner)
                return Forbid();

            _context.Comments.Remove(comment);
            _context.SaveChanges();

            return Ok();
        }
        [Authorize(Roles = "Admin")]
        [HttpGet("all")]
        public IActionResult GetAll()
        {
            var comments = _context.Comments
                .OrderByDescending(c => c.CreatedAt)
                .Select(c => new
                {
                    c.Id,
                    c.Text,
                    c.Rating,
                    c.UserName,
                    c.MovieId,

                    MovieTitle = _context.Movies
                        .Where(m => m.Id == c.MovieId)
                        .Select(m => m.Title)
                        .FirstOrDefault()
                })
                .ToList();

            return Ok(comments);
        }

        [Authorize]
        [HttpPost("{id}/like")]
        public IActionResult ToggleLike(int id)
        {
            var userId = User.FindFirstValue(ClaimTypes.NameIdentifier);

            var comment = _context.Comments.FirstOrDefault(c => c.Id == id);
            if (comment == null) return NotFound();

            var existingLike = _context.CommentLikes
                .FirstOrDefault(l => l.CommentId == id && l.UserId == userId);

            if (existingLike != null)
            {
                _context.CommentLikes.Remove(existingLike);
                comment.Likes--;
            }
            else
            {
                _context.CommentLikes.Add(new CommentLike
                {
                    CommentId = id,
                    UserId = userId
                });

                comment.Likes++;
            }

            _context.SaveChanges();

            return Ok(new { likes = comment.Likes });
        }
    }
}
