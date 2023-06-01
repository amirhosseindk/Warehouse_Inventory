using Application.Dto;
using Application.IServices;
using Infrastructure.IServices;
using Mapster;
using System.Security.Authentication;

namespace Infrastructure.Services
{
    public class UserService : IUserService
    {
        private readonly IUserRepository _userRepository;
        private readonly IUserCommandService _userCommandService;
        private readonly IPasswordHasher _passwordHasher;

        public UserService(IUserRepository userRepository, IUserCommandService userCommandService, IPasswordHasher passwordHasher)
        {
            _userRepository = userRepository;
            _userCommandService = userCommandService;
            _passwordHasher = passwordHasher;
        }

        public async Task<UserDto> GetUserByIdAsync(Guid userId, CancellationToken cancellationToken)
        {
            var user = await _userRepository.GetByIdAsync(userId, cancellationToken);
            return user.Adapt<UserDto>();
        }

        public async Task<IEnumerable<UserDto>> GetUsersAsync(CancellationToken cancellationToken)
        {
            var usersUS = await _userRepository.GetAllAsync(cancellationToken);
            return usersUS.Adapt<IEnumerable<UserDto>>();
        }

        public async Task<UserDto> CreateUserAsync(UserDto userDto, CancellationToken cancellationToken)
        {
            await _userCommandService.CreateUserAsync(userDto, cancellationToken);
            return userDto;
        }

        public async Task<UserDto> UpdateUserAsync(UserDto userDto, CancellationToken cancellationToken)
        {
            await _userCommandService.UpdateUserAsync(userDto, cancellationToken);
            return userDto;
        }

        public async Task DeleteUserAsync(Guid userId, CancellationToken cancellationToken)
        {
            await _userRepository.DeleteAsync(userId, cancellationToken);
        }

        public async Task<UserDto> AuthenticateAsync(string username, string password, CancellationToken cancellationToken)
        {
            var user = await _userRepository.GetByUsernameAsync(username, cancellationToken);

            if (user == null)
            {
                throw new AuthenticationException("Username or password is incorrect");
            }

            var verified = _passwordHasher.VerifyPassword(user.Password, password);

            if (!verified)
            {
                throw new AuthenticationException("Username or password is incorrect");
            }

            return user.Adapt<UserDto>();
        }
    }

}
