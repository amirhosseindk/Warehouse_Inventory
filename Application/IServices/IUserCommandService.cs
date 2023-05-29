using Domain.Dto;

namespace Application.IServices
{
    public interface IUserCommandService
    {
        Task CreateUserAsync(UserDto userDto, CancellationToken cancellationToken);
    }
}
