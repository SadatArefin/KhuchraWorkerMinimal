using KhuchraWorkerMinimal.Data.Entities;

namespace KhuchraWorkerMinimal.Interfaces;

public interface IUserService
{
    Task<IEnumerable<BaseUser>> GetAllUsersAsync();
    Task<BaseUser> GetUserByIdAsync(int id);
    Task<BaseUser> AddUserAsync(BaseUser user);
    Task<BaseUser> UpdateUserAsync(BaseUser user);
    Task DeleteUserAsync(int id);
}