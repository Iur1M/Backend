using System.Security.Claims;

namespace ProjectBackend.Service
{
    public class CurrentUserService : ICurrentUserService
    {
        private readonly IHttpContextAccessor _httpContextAccessor;

        public CurrentUserService(IHttpContextAccessor httpContextAccessor)
        {
            _httpContextAccessor = httpContextAccessor;
        }

        public string GetUserEmail()
        {
            return _httpContextAccessor.HttpContext?
                .User?
                .FindFirstValue(ClaimTypes.Email)
                ?? throw new Exception("User email not found in token");
        }
    }
}
