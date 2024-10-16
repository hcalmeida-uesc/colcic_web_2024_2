using Microsoft.AspNetCore.Mvc;
using UescColcicAPI.Services.Auth;

namespace UescColcicAPI.Controllers;

[Route("api/[controller]")]
[ApiController]
public class AuthController : ControllerBase
{
    private readonly AuthService _authService;

    public AuthController(AuthService authService)
    {
        _authService = authService;
    }
    
    [HttpPost("login")]
    public IActionResult Login([FromBody] UserLoginDto userLogin)
    {
        // Valide o usuário (exemplo simplificado)
        if (userLogin.Username == "admin" && userLogin.Password == "password")
        {
            var token = _authService.GenerateJwtToken();
            return Ok(new { token });
        }

        return Unauthorized();
    }

    
}

// DTO para login
public class UserLoginDto
{
    public string Username { get; set; }
    public string Password { get; set; }
}
