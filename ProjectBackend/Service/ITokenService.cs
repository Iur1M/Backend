using ProjectBackend.Domain.Entities;

namespace ProjectBackend.Service
{
    public interface ITokenService
    {
        Task<string> GenerateToken(ApplicationUser user);
        string GenerateRefreshToken();
    }
}
