namespace ProjectBackend.Domain.Entities
{
    public class WatchlistItem
    {
        public int Id { get; set; }
        public string UserId { get; set; } = string.Empty;
        public int MovieId { get; set; }

        public virtual Movie? Movie { get; set; }
    }
}
