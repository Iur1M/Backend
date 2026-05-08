using ProjectBackend.Domain.Entities.ProjectBackend.Domain.Entities;

namespace ProjectBackend.Domain.Entities
{
    public class Movie
    {
        public int Id { get; set; }
        public string Title { get; set; } = null!;
        public int Year { get; set; }
        public double Rating { get; set; }
        public string Director { get; set; } = null!;
        public string PosterUrl { get; set; } = null!;
        public string Genre { get; set; } = null!;
        public string? TrailerUrl { get; set; }
        public string Description { get; set; } = null!;
    }
}
