using Application.Dto;
using FluentValidation.Results;

namespace Application.IServices
{
    public interface IUserDtoValidator
    {
        ValidationResult Validate(UserDto userDto);
    }

}
