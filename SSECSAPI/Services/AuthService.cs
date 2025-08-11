using Microsoft.Extensions.Options;
using SSECSAPI.Data;
using SSECSAPI.DTO;
using SSECSAPI.Helpers;
using SSECSAPI.Models;
using SSECSAPI.Services;

public class AuthService : IAuthService
{
    private readonly JwtSettings _jwtSettings;
    private readonly AppDbContext _context;

    public AuthService(IOptions<JwtSettings> options, AppDbContext context)
    {
        _jwtSettings = options.Value;
        _context = context;
    }

    public AuthResponse Authenticate(Login model)
    {
        var user = _context.Users
            .FirstOrDefault(u => u.Email == model.Username && u.Password == model.Password);

        if (user == null)
        {
            return new AuthResponse
            {
                StatusCode = "404"
            };
        }

        var userRole = _context.UserRoles.FirstOrDefault(x => x.UserId == user.Id);
        if (userRole != null)
        {
            var role = _context.Roles.FirstOrDefault(r => r.Id == userRole.RoleId);
            var token = JwtTokenGenerator.GenerateToken(user.Email, _jwtSettings);

            return new AuthResponse
            {
                Token = token,
                User = user,
                Role = role,
                StatusCode = "200"
            };
        }
        else
        {
            return new AuthResponse
            {
                StatusCode = "403"
            };
        }
        
    }
    public string Register(Signup model)
    {
        var existingUser = _context.Users.FirstOrDefault(u => u.Email == model.Email);
        if (existingUser != null)
        {
            return "User with this email already exists.";
        }

        var user = new User
        {
            Name = model.Name,
            Mobile = model.Mobile,
            Email = model.Email,
            Password = model.Password // 🔐 In production, hash the password
        };

        _context.Users.Add(user);
        _context.SaveChanges();

        //var userRole = new UserRole
        //{
        //    UserId = user.Id,
        //    RoleId = model.RoleId
        //};

        //_context.UserRoles.Add(userRole);
        //_context.SaveChanges();

        return "Registration successful.";
    }
}
