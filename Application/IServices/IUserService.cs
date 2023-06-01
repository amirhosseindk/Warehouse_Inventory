using Application.Dto;

namespace Application.IServices
{
    public interface IUserService
    {
        Task<UserDto> GetUserByIdAsync(Guid userId, CancellationToken cancellationToken);
        Task<IEnumerable<UserDto>> GetUsersAsync(CancellationToken cancellationToken);
        Task<UserDto> CreateUserAsync(UserDto userDto, CancellationToken cancellationToken);
        Task<UserDto> UpdateUserAsync(UserDto userDto, CancellationToken cancellationToken);
        Task DeleteUserAsync(Guid userId, CancellationToken cancellationToken);
        Task<UserDto> AuthenticateAsync(string username, string password, CancellationToken cancellationToken);
    }
}
