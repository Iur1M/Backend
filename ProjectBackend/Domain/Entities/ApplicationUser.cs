using Microsoft.AspNetCore.Identity;

namespace ProjectBackend.Domain.Entities
{
    public class ApplicationUser : IdentityUser
    {
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string Gender    { get; set; }
        public string ? RefreshToken { get; set; }
        public DateTime? RefreshTokenEmpiryTime { get; set; }
        public DateTime CreateAt { get; set; }
        public DateTime UpdateAt   { get; set; }
        public DateTime RefreshTokenExpiryTime { get; internal set; }

        public int? FavoriteMovieId { get; set; }
        public virtual Movie? FavoriteMovie { get; set; }
    }
}
