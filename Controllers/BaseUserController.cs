using KhuchraWorkerMinimal.Data.Entities;
using KhuchraWorkerMinimal.Dto;
using KhuchraWorkerMinimal.Interfaces;
using Microsoft.AspNetCore.Mvc;

namespace KhuchraWorkerMinimal.Controllers;

[Route("api/[controller]")]
[ApiController]
public class BaseUserController(IUserService userService) : ControllerBase
{
    [HttpGet]
    public async Task<ActionResult<IEnumerable<BaseUser>>> GetUsers()
    {
        var users = await userService.GetAllUsersAsync();
        return Ok(users);
    }

    [HttpGet("{id}")]
    public async Task<ActionResult<BaseUser>> GetUser(int id)
    {
        var user = await userService.GetUserByIdAsync(id);
        return Ok(user);
    }

    [HttpPost]
    public async Task<ActionResult<BaseUser>> CreateUser(BaseUserDto userDto)
    {
        var user = new BaseUser { Name = userDto.Name, Email = userDto.Email };
        var createdUser = await userService.AddUserAsync(user);
        return CreatedAtAction(nameof(GetUser), new { id = createdUser.Id }, createdUser);
    }

    [HttpPut("{id}")]
    public async Task<IActionResult> UpdateUser(int id, BaseUserDto userDto)
    {
        var user = await userService.GetUserByIdAsync(id);

        user.Name = userDto.Name;
        user.Email = userDto.Email;
        await userService.UpdateUserAsync(user);

        return NoContent();
    }

    [HttpDelete("{id}")]
    public async Task<IActionResult> DeleteUser(int id)
    {
        await userService.DeleteUserAsync(id);
        return NoContent();
    }
}