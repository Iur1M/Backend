using ProjectBackend.Domain.Entities.ProjectBackend.Domain.Entities;

namespace ProjectBackend.Domain.Entities
{
    public class CommentLike
    {
        public int Id { get; set; }
        public int CommentId { get; set; }
        public Comment Comment { get; set; }
        public string UserId { get; set; }
    }
}
