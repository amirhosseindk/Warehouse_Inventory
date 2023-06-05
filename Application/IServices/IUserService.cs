using Application.ViewModels;

namespace Application.IServices
{   
    public interface IUserService
    {
        Task<UserViewModel> GetUserByIdAsync(Guid userId, CancellationToken cancellationToken);
        Task<IEnumerable<UserViewModel>> GetUsersAsync(CancellationToken cancellationToken);
        Task<UserViewModel> CreateUserAsync(UserViewModel userVM, CancellationToken cancellationToken);
        Task<UserViewModel> UpdateUserAsync(UserViewModel userVM, CancellationToken cancellationToken);
        Task DeleteUserAsync(Guid userId, CancellationToken cancellationToken);
        Task<UserViewModel> AuthenticateAsync(string username, string password, CancellationToken cancellationToken);
    }
}
