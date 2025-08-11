using Microsoft.AspNetCore.Mvc;
using SSECSAPI.DTO;
using SSECSAPI.Services;

[ApiController]
[Route("api/[controller]")]
public class AuthController : ControllerBase
{
    private readonly IAuthService _authService;

    public AuthController(IAuthService authService)
    {
        _authService = authService;
    }

    [HttpPost("login")]
    public IActionResult Login([FromBody] Login model)
    {
        var result = _authService.Authenticate(model);


        return Ok(new
        {
            result.Token,
            result.User,
            result.Role,
            result.StatusCode
        });
    }
    [HttpPost("signup")]
    public IActionResult Signup([FromBody] Signup model)
    {
        var message = _authService.Register(model);
        if (message == "User with this email already exists.")
            return BadRequest(new { Message = message });

        return Ok(new { Message = message });
    }
}
