using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using ProjectBackend.Domain.Entities;
using ProjectBackend.Domain.Entities.ProjectBackend.Domain.Entities;
using ProjectBackend.Infrastructure.Seed;

namespace DotnetAuth.Infrastructure.Context
{
    public class ApplicationDbContext : IdentityDbContext<ApplicationUser>
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options)
            : base(options)
        {
        }

        public DbSet<Movie> Movies { get; set; }
        public DbSet<Comment> Comments { get; set; }
        public DbSet<UserActivity> UserActivities { get; set; }
        public DbSet<CommentLike> CommentLikes { get; set; }
        public DbSet<WatchlistItem> WatchlistItems { get; set; }

        protected override void OnModelCreating(ModelBuilder builder)
        {
            base.OnModelCreating(builder);
            MovieSeeder.SeedMovies(builder);
        }
    }
}