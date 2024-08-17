using Accounting.Domain;
using Accounting.Domain.Repositories;
using Microsoft.AspNetCore.Mvc;

namespace Accounting.API;

[ApiController]
[Route("api/[controller]")]
public class UsersController : Controller
{
    private readonly IUserRepository _userService;

    public UsersController(IUserRepository userService)
    {
        _userService = userService;
    }

    [HttpGet]
    public async Task<IActionResult> GetAll()
    {
        var users = await _userService.GetAllAsync();
        return Ok(users);
    }

    [HttpPost]
    public async Task<IActionResult> Create(User userDto)
    {
        await _userService.AddAsync(userDto);
        return CreatedAtAction(nameof(GetAll), new { id = userDto.UserId }, userDto);
    }
}