using Application.IServices;
using Application.ViewModels.ConsumerViewModels;
using FluentValidation;

namespace Application.Services
{
    public class ConsumerVMValidator : AbstractValidator<ConVMCU>, IConsumerVMValidator
    {
        public ConsumerVMValidator()
        {
            RuleFor(x => x.Id).NotEmpty();
            RuleFor(x => x.Name).NotEmpty();
            RuleFor(x => x.LastName).NotEmpty();
            RuleFor(x => x.Phone).NotEmpty();
            RuleFor(x => x.Email).EmailAddress().NotEmpty();
        }
    }
}
