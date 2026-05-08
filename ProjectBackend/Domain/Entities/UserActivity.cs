namespace ProjectBackend.Domain.Entities
{
    public class UserActivity
    {
        public int Id { get; set; }
        public string UserId { get; set; } = null!;
        public int MovieId { get; set; }
        public string ActivityType { get; set; } = null!;
        public DateTime CreatedAt { get; set; } = DateTime.UtcNow;
    }
}
