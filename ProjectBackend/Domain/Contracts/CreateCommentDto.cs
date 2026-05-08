namespace ProjectBackend.Domain.Contracts
{
    public class CreateCommentDto
    {
        public int MovieId { get; set; }
        public string Text { get; set; }
        public int Rating { get; set; }
    }
}
