using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;

using PlantApp.Api.Controller;
using PlantApp.Api.Models;

using static PlantApp.Api.DTOs.AuthDtos;

[ApiController]
[Route("api/auth")]
public class AuthController : ControllerBase
{
    private readonly UserManager<ApplicationUser> _userManager;
    private readonly IConfiguration _config;

    public AuthController(
        UserManager<ApplicationUser> userManager,
        IConfiguration config)
    {
        _userManager = userManager;
        _config = config;
    }

    [HttpPost("register")]
    public async Task<IActionResult> Register(RegisterDto dto)
    {
        var user = new ApplicationUser
        {
            UserName = dto.Email,
            Email = dto.Email
        };

        var result = await _userManager.CreateAsync(user, dto.Password);
        if (!result.Succeeded)
            return BadRequest(result.Errors);

        return Ok();
    }

    [HttpPost("login")]
    public async Task<IActionResult> Login(LoginDto dto)
    {
        var user = await _userManager.FindByEmailAsync(dto.Email);
        if (user == null)
            return Unauthorized();

        if (!await _userManager.CheckPasswordAsync(user, dto.Password))
            return Unauthorized();

        var token = JwtTokenHelper.Create(user, _config["JwtKey"]!);
        return Ok(new { token });
    }
}
