using KhuchraWorkerMinimal.Data;
using KhuchraWorkerMinimal.Entities;
using KhuchraWorkerMinimal.Interfaces;
using Microsoft.EntityFrameworkCore;

namespace KhuchraWorkerMinimal.Services;

public class UserService: IUserService
{
    private readonly KhuchraWorkerContext _context;

    public UserService(KhuchraWorkerContext context)
    {
        _context = context;
    }

    public async Task<IEnumerable<BaseUser>> GetAllUsersAsync() => await _context.Users.ToListAsync();

    public async Task<BaseUser> GetUserByIdAsync(int id) => await _context.Users.FindAsync(id);

    public async Task<BaseUser> AddUserAsync(BaseUser user)
    {
        _context.Users.Add(user);
        await _context.SaveChangesAsync();
        return user;
    }

    public async Task<BaseUser> UpdateUserAsync(BaseUser user)
    {
        _context.Users.Update(user);
        await _context.SaveChangesAsync();
        return user;
    }

    public async Task DeleteUserAsync(int id)
    {
        var user = await GetUserByIdAsync(id);
        if (user != null)
        {
            _context.Users.Remove(user);
            await _context.SaveChangesAsync();
        }
    }
}