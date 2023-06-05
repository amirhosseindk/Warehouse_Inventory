using Application.Dto;
using Application.IServices;
using Domain.Entities;
using FluentValidation;
using Infrastructure.IServices;
using Mapster;
using Microsoft.Extensions.Logging;

namespace Infrastructure.Services
{
    public class UserCommandService : IUserCommandService
    {
        private readonly ILogger<UserCommandService> _logger;
        private readonly IUnitOfWork _unitOfWork;
        private readonly IValidator<UserDto> _validator;
        private readonly IPasswordHasher _passwordHasher;

        public UserCommandService(ILogger<UserCommandService> logger, IUnitOfWork unitOfWork, IValidator<UserDto> validator, IPasswordHasher passwordHasher)
        {
            _logger = logger;
            _unitOfWork = unitOfWork;
            _validator = validator;
            _passwordHasher = passwordHasher;
        }

        public async Task CreateUserAsync(UserDto userDto, CancellationToken cancellationToken)
        {
            var validationResult = await _validator.ValidateAsync(userDto, cancellationToken);
            if (!validationResult.IsValid)
            {
                throw new FluentValidation.ValidationException(validationResult.Errors);
            }

            var user = userDto.Adapt<User>();
            user.Password = _passwordHasher.HashPassword(userDto.Password);
            user.ByUsername = "eb";

            try
            {
                await _unitOfWork.Users.CreateAsync(user, cancellationToken);
                await _unitOfWork.CompleteAsync(cancellationToken);
                _logger.LogInformation("User created successfully");
            }
            catch (Exception ex)
            {
                _logger.LogError(ex, "Error creating user {User}", userDto);
                throw;
            }
        }

        public async Task UpdateUserAsync(UserDto userDto, CancellationToken cancellationToken)
        {
            var validationResult = await _validator.ValidateAsync(userDto, cancellationToken);
            if (!validationResult.IsValid)
            {
                throw new FluentValidation.ValidationException(validationResult.Errors);
            }

            var user = userDto.Adapt<User>();
            user.Password = _passwordHasher.HashPassword(userDto.Password);

            try
            {
                await _unitOfWork.Users.UpdateAsync(user, cancellationToken);
                await _unitOfWork.CompleteAsync(cancellationToken);
            }
            catch (Exception ex)
            {
                _logger.LogError(ex, "Error updating user {User}", userDto);
                throw;
            }
        }
    }
}
