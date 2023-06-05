using Application.ViewModels;
using Application.IServices;
using FluentValidation;

namespace Application.Services
{
    public class UserVMValidator : AbstractValidator<UserViewModel>, IUserVMValidator
    {
        public UserVMValidator()
        {
            RuleFor(x => x.UserId).NotEmpty();
            RuleFor(x => x.FirstName).NotEmpty();
            RuleFor(x => x.LastName).NotEmpty();
            RuleFor(x => x.Username).NotEmpty().MinimumLength(3);
            RuleFor(x => x.Password).NotEmpty().MinimumLength(8);
            RuleFor(x => x.Role).NotEmpty();
            RuleFor(x => x.Email).EmailAddress();
        }
    }
}
