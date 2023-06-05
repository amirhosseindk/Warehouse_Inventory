using Application.ViewModels;

namespace Application.IServices
{
    public interface IUserCommandService
    {
        Task CreateUserAsync(UserViewModel userVM, CancellationToken cancellationToken);
        Task UpdateUserAsync(UserViewModel userVM, CancellationToken cancellationToken);
    }
}
