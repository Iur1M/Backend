using ProjectBackend.Domain.Contracts;

namespace ProjectBackend.Service
{
    public interface IMovieService
    {
        Task<MoviePagedResponse> GetMovies(
            string? search,
            string? director,
            int? year,
            double? minRating,
            double? maxRating,
            string? genre,
            string? sortBy,
            bool desc,
            int page,
            int pageSize);

        Task<MovieDto?> GetMovieByIdAsync(int id);

        Task<MovieDto> AddMovieAsync(AddMovieDto dto);
        Task<bool> DeleteMovieAsync(int id);

        Task<MovieDto> UpdateMovieAsync(int id, AddMovieDto dto);
    }
}
