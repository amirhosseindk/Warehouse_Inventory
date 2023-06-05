using Application.ViewModels;
using FluentValidation.Results;

namespace Application.IServices
{
    public interface IUserVMValidator
    {
        ValidationResult Validate(UserViewModel userVM);
    }

}
