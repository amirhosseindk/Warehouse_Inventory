using Domain.Entities;

namespace Application.IServices
{
    public interface IUserService
    {
        Task<User> GetUserByIdAsync(Guid userId, CancellationToken cancellationToken);
        Task<IEnumerable<User>> GetUsersAsync(CancellationToken cancellationToken);
        Task<User> CreateUserAsync(User user, CancellationToken cancellationToken);
        Task<User> UpdateUserAsync(User user, CancellationToken cancellationToken);
        Task DeleteUserAsync(Guid userId, CancellationToken cancellationToken);
    }
}
