﻿using Application.ViewModels.UserViewModels;

namespace Application.IServices
{
    public interface IUserService
    {
        Task<UserVMCU> GetUserByIdAsync(UserVMId userVMId, CancellationToken cancellationToken);
        Task<IEnumerable<UserVMCU>> GetUsersAsync(CancellationToken cancellationToken);
        Task<UserVMCU> CreateUserAsync(UserVMCU userVM, CancellationToken cancellationToken);
        Task<UserVMCU> UpdateUserAsync(UserVMCU userVM, CancellationToken cancellationToken);
        Task DeleteUserAsync(UserVMId userVMId, CancellationToken cancellationToken);
        Task<bool> AuthenticateAsync(UserVMAuth userVMAuth, CancellationToken cancellationToken);
    }
}
