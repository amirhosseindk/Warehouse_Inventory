using Application.ViewModels;
using Application.IServices;
using Infrastructure.IServices;
using Mapster;

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

        public async Task<UserViewModel> GetUserByIdAsync(Guid userId, CancellationToken cancellationToken)
        {
            var user = await _userRepository.GetByIdAsync(userId, cancellationToken);
            return user.Adapt<UserViewModel>();
        }

        public async Task<IEnumerable<UserViewModel>> GetUsersAsync(CancellationToken cancellationToken)
        {
            var usersUS = await _userRepository.GetAllAsync(cancellationToken);
            return usersUS.Adapt<IEnumerable<UserViewModel>>();
        }

        public async Task<UserViewModel> CreateUserAsync(UserViewModel userVM, CancellationToken cancellationToken)
        {
            await _userCommandService.CreateUserAsync(userVM, cancellationToken);
            return userVM;
        }

        public async Task<UserViewModel> UpdateUserAsync(UserViewModel userVM, CancellationToken cancellationToken)
        {
            await _userCommandService.UpdateUserAsync(userVM, cancellationToken);
            return userVM;
        }

        public async Task DeleteUserAsync(Guid userId, CancellationToken cancellationToken)
        {
            await _userRepository.DeleteAsync(userId, cancellationToken);
        }

        public async Task<bool> AuthenticateAsync(string username, string password, CancellationToken cancellationToken)
        {
            var user = await _userRepository.GetByUsernameAsync(username, cancellationToken);
            var verified = _passwordHasher.VerifyPassword(user.Password, password);

            if (verified)
            {
                return true;
            }
            else
            {
                return false;
            }
        }
    }

}
