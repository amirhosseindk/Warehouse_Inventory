using Application.IServices;
using Infrastructure.IServices;
using Mapster;
using Application.ViewModels.UserViewModels;

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

        public async Task<UserVMCU> GetUserAsync(UserVMId userVMId, CancellationToken cancellationToken)
        {
            var user = await _userRepository.GetUserAsync(userVMId.UserId, cancellationToken);
            return user.Adapt<UserVMCU>();
        }

        public async Task<UserVMCU> GetUserByIdAsync(UserVMId userVMId, CancellationToken cancellationToken)
        {
            var user = await _userRepository.GetByIdAsync(userVMId.UserId, cancellationToken);
            return user.Adapt<UserVMCU>();
        }

        public async Task<IEnumerable<UserVMCU>> GetUsersAsync(CancellationToken cancellationToken)
        {
            var usersUS = await _userRepository.GetAllAsync(cancellationToken);
            return usersUS.Adapt<IEnumerable<UserVMCU>>();
        }

        public async Task<UserVMCU> CreateUserAsync(UserVMCU userVM, CancellationToken cancellationToken)
        {
            await _userCommandService.CreateUserAsync(userVM, cancellationToken);
            return userVM;
        }

        public async Task<UserVMCU> UpdateUserAsync(UserVMCU userVM, CancellationToken cancellationToken)
        {
            await _userCommandService.UpdateUserAsync(userVM, cancellationToken);
            return userVM;
        }

        public async Task DeleteUserAsync(UserVMId userVMId, CancellationToken cancellationToken)
        {
            await _userRepository.DeleteAsync(userVMId.UserId, cancellationToken);
        }

        public async Task<bool> AuthenticateAsync(UserVMAuth userVMAuth, CancellationToken cancellationToken)
        {
            bool verified = false;
            var user = await _userRepository.GetByUsernameAsync(userVMAuth.UserName, cancellationToken);
            if (user != null) 
            {
                if (user.IsActive)
                {
                    verified = _passwordHasher.VerifyPassword(user.Password, userVMAuth.Password);
                }
            }
          

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
