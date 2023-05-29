﻿using Application.IServices;
using Domain.Dto;
using Domain.Entities;
using FluentValidation;
using Mapster;
using Microsoft.Extensions.Logging;
using Persistence.Migrations;

namespace Persistence.Services
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


            try
            {
                await _unitOfWork.Users.AddAsync(user, cancellationToken);
                await _unitOfWork.CompleteAsync(cancellationToken);
            }
            catch (Exception ex)
            {
                _logger.LogError(ex, "Error creating user {User}", userDto);
                throw;
            }
        }
    }

}