using DotnetAuth.Infrastructure.Context;
using Microsoft.EntityFrameworkCore;
using ProjectBackend.Domain.Contracts;
using ProjectBackend.Domain.Entities;

namespace ProjectBackend.Service.Implementations
{
    public class MovieService : IMovieService
    {
        private readonly ApplicationDbContext _context;

        public MovieService(ApplicationDbContext context)
        {
            _context = context;
        }

        public async Task<MoviePagedResponse> GetMovies(
            string? search,
            string? director,
            int? year,
            double? minRating,
            double? maxRating,
            string? genre,
            string? sortBy,
            bool desc,
            int page,
            int pageSize)
        {
            IQueryable<Movie> query = _context.Movies;

            if (!string.IsNullOrWhiteSpace(search))
                query = query.Where(m => m.Title.Contains(search));

            if (!string.IsNullOrWhiteSpace(director))
                query = query.Where(m => m.Director.Contains(director));

            if (year.HasValue)
                query = query.Where(m => m.Year == year);

            if (minRating.HasValue)
                query = query.Where(m => m.Rating >= minRating);

            if (maxRating.HasValue)
                query = query.Where(m => m.Rating <= maxRating);

            if (!string.IsNullOrWhiteSpace(genre))
                query = query.Where(m => m.Genre.ToLower() == genre.ToLower());

            query = sortBy switch
            {
                "rating" => desc
                    ? query.OrderByDescending(m => m.Rating)
                    : query.OrderBy(m => m.Rating),

                "year" => desc
                    ? query.OrderByDescending(m => m.Year)
                    : query.OrderBy(m => m.Year),

                _ => query.OrderBy(m => m.Title)
            };

            var totalCount = await query.CountAsync();

            var movies = await query
                .Skip((page - 1) * pageSize)
                .Take(pageSize)
                .ToListAsync();

            return new MoviePagedResponse
            {
                Items = movies,
                TotalCount = totalCount,
                Page = page,
                PageSize = pageSize
            };
        }
        public async Task<MovieDto?> GetMovieByIdAsync(int id)
        {
            var movie = await _context.Movies.FirstOrDefaultAsync(m => m.Id == id);

            if (movie == null)
                return null;

            return new MovieDto
            {
                Id = movie.Id,
                Title = movie.Title,
                Director = movie.Director,
                Year = movie.Year,
                Rating = movie.Rating,
                Genre = movie.Genre,
                PosterUrl = movie.PosterUrl,
                TrailerUrl = movie.TrailerUrl,
                Description = movie.Description
            };
        }

        public async Task<MovieDto> AddMovieAsync(AddMovieDto dto)
        {
            var movie = new Movie
            {
                Title = dto.Title,
                Director = dto.Director,
                Year = dto.Year,
                Rating = dto.Rating,
                Genre = dto.Genre,
                PosterUrl = dto.PosterUrl,
                TrailerUrl = dto.TrailerUrl,
                Description = dto.Description
            };

            _context.Movies.Add(movie);
            await _context.SaveChangesAsync();

            return new MovieDto
            {
                Id = movie.Id,
                Title = movie.Title,
                Director = movie.Director,
                Year = movie.Year,
                Rating = movie.Rating,
                Genre = movie.Genre,
                PosterUrl = movie.PosterUrl,
                TrailerUrl = movie.TrailerUrl,
                Description = movie.Description
            };
        }

        public async Task<bool> DeleteMovieAsync(int id)
        {
            var movie = await _context.Movies.FindAsync(id);

            if (movie == null)
                return false;

            _context.Movies.Remove(movie);
            await _context.SaveChangesAsync();

            return true;
        }
        public async Task<MovieDto> UpdateMovieAsync(int id, AddMovieDto dto)
        {
            var movie = await _context.Movies.FindAsync(id);

            if (movie == null)
                throw new Exception("Movie not found");

            movie.Title = dto.Title;
            movie.Year = dto.Year;
            movie.Rating = dto.Rating;
            movie.Director = dto.Director;
            movie.Genre = dto.Genre;
            movie.PosterUrl = dto.PosterUrl;
            movie.TrailerUrl = dto.TrailerUrl;
            movie.Description = dto.Description;

            await _context.SaveChangesAsync();

            return new MovieDto
            {
                Id = movie.Id,
                Title = movie.Title,
                Year = movie.Year,
                Rating = movie.Rating,
                Director = movie.Director,
                Genre = movie.Genre,
                PosterUrl = movie.PosterUrl,
                TrailerUrl = movie.TrailerUrl,
                Description = movie.Description
            };
        }
    }

}
