namespace ProjectBackend.Domain.Contracts
{
    public class MovieDto
    {
        public int Id { get; set; }
        public string Title { get; set; } = null!;
        public int Year { get; set; }
        public double Rating { get; set; }
        public string Director { get; set; } = null!;
        public string? PosterUrl { get; set; }
        public string Genre { get; set; } = null!;
        public string? TrailerUrl { get; set; }
        public string Description { get; set; } = null!;
    }
}
