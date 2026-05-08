using ProjectBackend.Domain.Contracts;

namespace ProjectBackend.Service
{
    public interface IUserServices
    {

        Task<UserResponse> RegisterAsync(UserRegisterRequest request);
        Task<CurrentUserResponse> GetCurrentUserAsync();
        Task<UserResponse> GetByIdAsync(Guid id);
        Task<UserResponse> UpdateAsync(Guid id, UpdateUserRequest request);
        Task DeleteAsync(Guid id);
        Task<RevokeRefreshTokenResponse> RevokeRefreshToken(RefreshTokenRequest refreshTokenRemoveRequest);
        Task<CurrentUserResponse> RefreshTokenAsync(RefreshTokenRequest request);

        Task<IEnumerable<UserResponse>> GetAllAsync();
        Task<UserResponse> LoginAsync(UserLoginRequest request);
        Task UpdateFavoriteMovieAsync(int movieId);
    }
}
