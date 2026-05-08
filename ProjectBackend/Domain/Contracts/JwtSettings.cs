namespace ProjectBackend.Domain.Contracts
{
    public class JwtSettings
    {
        public string Key { get; set; } = null!;
        public string ValidIssuer { get; set; } = null!;
        public string ValidAudience { get; set; } = null!;
        public double Expires { get; set; }
    }
}
