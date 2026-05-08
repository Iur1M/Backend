using AutoMapper;
using Microsoft.AspNetCore.Identity;
using Microsoft.EntityFrameworkCore;
using ProjectBackend.Domain.Contracts;
using ProjectBackend.Domain.Entities;
using ProjectBackend.Domain.Exceptions;
using System.Security.Cryptography;
using System.Text;

namespace ProjectBackend.Service
{
    public class UserServiceImpl : IUserServices
    {
        private readonly ITokenService _tokenService;
        private readonly ICurrentUserService _currentUserService;
        private readonly UserManager<ApplicationUser> _userManager;
        private readonly RoleManager<IdentityRole> _roleManager;
        private readonly IMapper _mapper;
        private readonly ILogger<UserServiceImpl> _logger;

        public UserServiceImpl(
            ITokenService tokenService,
            ICurrentUserService currentUserService,
            UserManager<ApplicationUser> userManager,
            RoleManager<IdentityRole> roleManager,
            IMapper mapper,
            ILogger<UserServiceImpl> logger)
        {
            _tokenService = tokenService;
            _currentUserService = currentUserService;
            _userManager = userManager;
            _roleManager = roleManager;
            _mapper = mapper;
            _logger = logger;
        }

        public async Task<UserResponse> RegisterAsync(UserRegisterRequest request)
        {
            _logger.LogInformation("Registering user");

            var existingUser = await _userManager.FindByEmailAsync(request.Email);
            if (existingUser != null)
            {
                throw new ValidationException(new[]
                {
                    "Email is already registered"
                });
            }

            var newUser = _mapper.Map<ApplicationUser>(request);
            newUser.UserName = GenerateUserName(request.FirstName, request.LastName);

            var result = await _userManager.CreateAsync(newUser, request.Password);
            if (!result.Succeeded)
            {
                var errors = result.Errors.Select(e => e.Description);
                throw new ValidationException(errors);
            }

            if (!await _roleManager.RoleExistsAsync("User"))
            {
                await _roleManager.CreateAsync(new IdentityRole("User"));
            }

            await _userManager.AddToRoleAsync(newUser, "User");

            await _tokenService.GenerateToken(newUser);

            newUser.CreateAt = DateTime.Now;
            newUser.UpdateAt = DateTime.Now;

            return _mapper.Map<UserResponse>(newUser);
        }

        private string GenerateUserName(string firstName, string lastName)
        {
            var baseUsername = $"{firstName}{lastName}".ToLower();
            var username = baseUsername;
            var count = 1;

            while (_userManager.Users.Any(u => u.UserName == username))
            {
                username = $"{baseUsername}{count}";
                count++;
            }

            return username;
        }


        public async Task<UserResponse> LoginAsync(UserLoginRequest request)
        {
            if (request == null)
                throw new ArgumentNullException(nameof(request));

            var user = await _userManager.FindByEmailAsync(request.Email);
            if (user == null || !await _userManager.CheckPasswordAsync(user, request.Password))
                throw new Exception("Invalid email or password");

            var token = await _tokenService.GenerateToken(user);
            var refreshToken = _tokenService.GenerateRefreshToken();

            using var sha256 = SHA256.Create();
            var refreshTokenHash = sha256.ComputeHash(Encoding.UTF8.GetBytes(refreshToken));
            user.RefreshToken = Convert.ToBase64String(refreshTokenHash);
            user.RefreshTokenExpiryTime = DateTime.Now.AddDays(2);
            user.CreateAt = DateTime.Now;

            await _userManager.UpdateAsync(user);

            var userResponse = _mapper.Map<UserResponse>(user);
            userResponse.AccessToken = token;
            userResponse.RefreshToken = refreshToken;

            return userResponse;
        }

        public async Task<UserResponse> GetByIdAsync(Guid id)
        {
            var user = await _userManager.FindByIdAsync(id.ToString());
            if (user == null)
                throw new Exception("User not found");

            return _mapper.Map<UserResponse>(user);
        }

        public async Task<CurrentUserResponse> GetCurrentUserAsync()
        {
            var email = _currentUserService.GetUserEmail();

            var user = await _userManager.Users
                .Include(u => u.FavoriteMovie)
                .FirstOrDefaultAsync(u => u.Email == email);

            if (user == null)
                throw new Exception("User not found");

            var response = _mapper.Map<CurrentUserResponse>(user);

            response.FavoriteMoviePoster = user.FavoriteMovie?.PosterUrl;

            return response;
        }

        public async Task<CurrentUserResponse> RefreshTokenAsync(RefreshTokenRequest request)
        {
            using var sha256 = SHA256.Create();
            var refreshTokenHash = sha256.ComputeHash(Encoding.UTF8.GetBytes(request.RefreshToken));
            var hashedRefreshToken = Convert.ToBase64String(refreshTokenHash);

            var user = await _userManager.Users.FirstOrDefaultAsync(u => u.RefreshToken == hashedRefreshToken);
            if (user == null || user.RefreshTokenExpiryTime < DateTime.Now)
                throw new Exception("Invalid or expired refresh token");

            var newAccessToken = await _tokenService.GenerateToken(user);
            var response = _mapper.Map<CurrentUserResponse>(user);
            response.AccessToken = newAccessToken;

            return response;
        }

        public async Task<RevokeRefreshTokenResponse> RevokeRefreshToken(RefreshTokenRequest request)
        {
            using var sha256 = SHA256.Create();
            var refreshTokenHash = sha256.ComputeHash(Encoding.UTF8.GetBytes(request.RefreshToken));
            var hashedRefreshToken = Convert.ToBase64String(refreshTokenHash);

            var user = await _userManager.Users.FirstOrDefaultAsync(u => u.RefreshToken == hashedRefreshToken);
            if (user == null)
                throw new Exception("Invalid refresh token");

            user.RefreshToken = null;
            user.RefreshTokenEmpiryTime = null;

            await _userManager.UpdateAsync(user);

            return new RevokeRefreshTokenResponse
            {
                Message = "Refresh token revoked successfully"
            };
        }

        public async Task<UserResponse> UpdateAsync(Guid id, UpdateUserRequest request)
        {
            var user = await _userManager.FindByIdAsync(id.ToString());
            if (user == null)
                throw new Exception("User not found");

            user.FirstName = request.FirstName;
            user.LastName = request.LastName;
            user.Email = request.Email;
            user.Gender = request.Gender;
            user.UpdateAt = DateTime.Now;

            await _userManager.UpdateAsync(user);

            return _mapper.Map<UserResponse>(user);
        }

        public async Task DeleteAsync(Guid id)
        {
            var user = await _userManager.FindByIdAsync(id.ToString());

            if (user == null)
                throw new Exception("User not found");

            var currentEmail = _currentUserService.GetUserEmail();

            if (user.Email == currentEmail)
                throw new Exception("You cannot delete yourself");

            await _userManager.DeleteAsync(user);
        }
        public async Task UpdateFavoriteMovieAsync(int movieId)
        {
            var userEmail = _currentUserService.GetUserEmail();

            var user = await _userManager.FindByEmailAsync(userEmail);

            if (user == null)
            {
                throw new Exception("User not found");
            }

            user.FavoriteMovieId = movieId;
            user.UpdateAt = DateTime.Now;

            var result = await _userManager.UpdateAsync(user);

            if (!result.Succeeded)
            {
                var errors = string.Join(", ", result.Errors.Select(e => e.Description));
                throw new Exception($"Failed to update favorite movie: {errors}");
            }
        }
        public async Task<IEnumerable<UserResponse>> GetAllAsync()
        {
            var users = await _userManager.Users.ToListAsync();

            return users.Select(u => new UserResponse
            {
                Id = Guid.Parse(u.Id),
                FirstName = u.FirstName,
                LastName = u.LastName,
                Email = u.Email,
                Gender = u.Gender,
                CreateAt = u.CreateAt,
                UpdateAt = u.UpdateAt
            });
        }
    }
}