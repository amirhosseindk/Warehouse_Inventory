using Application.IServices;
using Domain.Entities;
using FluentValidation;
using Infrastructure.IServices;
using Mapster;
using Application.ViewModels.UserViewModels;

namespace Infrastructure.Services
{
    public class UserCommandService : IUserCommandService
    {
        //private readonly ILogger<UserCommandService> _logger;
        private readonly IUnitOfWork _unitOfWork;
        private readonly IValidator<UserVMCU> _validator;
        private readonly IPasswordHasher _passwordHasher;

        public UserCommandService(/*ILogger<UserCommandService> logger,*/ IUnitOfWork unitOfWork, IValidator<UserVMCU> validator, IPasswordHasher passwordHasher)
        {
            //_logger = logger;
            _unitOfWork = unitOfWork;
            _validator = validator;
            _passwordHasher = passwordHasher;
        }

        public async Task CreateUserAsync(UserVMCU userVM, CancellationToken cancellationToken)
        {
            var validationResult = await _validator.ValidateAsync(userVM, cancellationToken);
            if (!validationResult.IsValid)
            {
                throw new FluentValidation.ValidationException(validationResult.Errors);
            }

            var user = userVM.Adapt<User>();
            user.Password = _passwordHasher.HashPassword(userVM.Password);
            user.UsernameId = "eb";

            try
            {
                await _unitOfWork.Users.CreateAsync(user, cancellationToken);
                await _unitOfWork.CompleteAsync(cancellationToken);
                //_logger.LogInformation("User created successfully");
            }
            catch (Exception ex)
            {
                //_logger.LogError(ex, "Error creating user {User}", userVM);
                throw ex;
            }
        }

        public async Task UpdateUserAsync(UserVMCU userVM, CancellationToken cancellationToken)
        {
            var validationResult = await _validator.ValidateAsync(userVM, cancellationToken);
            if (!validationResult.IsValid)
            {
                throw new FluentValidation.ValidationException(validationResult.Errors);
            }

            var user = userVM.Adapt<User>();
            user.Password = _passwordHasher.HashPassword(userVM.Password);

            try
            {
                await _unitOfWork.Users.UpdateAsync(user, cancellationToken);
                await _unitOfWork.CompleteAsync(cancellationToken);
            }
            catch (Exception ex)
            {
                //_logger.LogError(ex, "Error updating user {User}", userVM);
                throw ex;
            }
        }
    }
}
