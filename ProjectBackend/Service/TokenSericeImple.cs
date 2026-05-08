using Microsoft.AspNetCore.Identity;
using Microsoft.IdentityModel.Tokens;
using ProjectBackend.Domain.Contracts;
using ProjectBackend.Domain.Entities;
using System.IdentityModel.Tokens.Jwt;
using System.Security.Claims;
using System.Security.Cryptography;
using System.Text;

namespace ProjectBackend.Service
{
    public class TokenServiceImple : ITokenService
    {
        private readonly SymmetricSecurityKey _secretKey;
        private readonly string _validIssuer;
        private readonly string _validAudience;
        private readonly double _expires;
        private readonly UserManager<ApplicationUser> _userManager;

        public TokenServiceImple(
            IConfiguration configuration,
            UserManager<ApplicationUser> userManager)
        {
            _userManager = userManager;

            var jwtSettings = configuration.GetSection("JwtSettings").Get<JwtSettings>()
                ?? throw new InvalidOperationException("JWT settings missing");

            _secretKey = new SymmetricSecurityKey(Encoding.UTF8.GetBytes(jwtSettings.Key));
            _validIssuer = jwtSettings.ValidIssuer;
            _validAudience = jwtSettings.ValidAudience;
            _expires = jwtSettings.Expires;
        }

        public async Task<string> GenerateToken(ApplicationUser user)
        {
            var signingCredentials =
                new SigningCredentials(_secretKey, SecurityAlgorithms.HmacSha256);

            var claims = await GetClaimsAsync(user);

            var token = new JwtSecurityToken(
                issuer: _validIssuer,
                audience: _validAudience,
                claims: claims,
                expires: DateTime.UtcNow.AddMinutes(_expires),
                signingCredentials: signingCredentials
            );

            return new JwtSecurityTokenHandler().WriteToken(token);
        }

        private async Task<List<Claim>> GetClaimsAsync(ApplicationUser user)
        {
            var claims = new List<Claim>
                {
                    new Claim(JwtRegisteredClaimNames.Sub, user.UserName ?? user.Email ?? ""),
                    new Claim(JwtRegisteredClaimNames.Jti, Guid.NewGuid().ToString()),

                    new Claim(ClaimTypes.Name, user.UserName ?? ""),
                    new Claim(ClaimTypes.NameIdentifier, user.Id),
                    new Claim(ClaimTypes.Email, user.Email ?? ""),

                    new Claim("FirstName", user.FirstName ?? ""),
                    new Claim("LastName", user.LastName ?? ""),
                    new Claim("Gender", user.Gender ?? "")
                };

            var roles = await _userManager.GetRolesAsync(user);
            foreach (var role in roles)
            {
                claims.Add(new Claim(ClaimTypes.Role, role));
            }

            return claims;
        }

        public string GenerateRefreshToken()
        {
            var randomNumber = new byte[64];
            using var rng = RandomNumberGenerator.Create();
            rng.GetBytes(randomNumber);
            return Convert.ToBase64String(randomNumber);
        }
    }
}