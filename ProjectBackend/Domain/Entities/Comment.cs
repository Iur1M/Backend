namespace ProjectBackend.Domain.Entities
{
    using System;

    namespace ProjectBackend.Domain.Entities
    {
        public class Comment
        {
            public int Id { get; set; }
            public string Text { get; set; }
            public int MovieId { get; set; }
            public string UserId { get; set; }
            public string UserName { get; set; }
            public int Rating { get; set; }
            public int Likes { get; set; } = 0;
            public DateTime CreatedAt { get; set; } = DateTime.UtcNow;
        }
    }
}
