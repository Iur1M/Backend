namespace ProjectBackend.Domain.Contracts
{
    public class MoviePagedResponse
    {
        public IEnumerable<object> Items { get; set; } = [];
        public int TotalCount { get; set; }
        public int Page { get; set; }
        public int PageSize { get; set; }
    }
}