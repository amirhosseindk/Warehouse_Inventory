using Application.IServices;
using Application.ViewModels.SupplierViewModels;
using FluentValidation;

namespace Application.Services
{
    public class SupplierVMValidator : AbstractValidator<SupVMCU>, ISupplierVMValidator
    {
        public SupplierVMValidator()
        {
            RuleFor(x => x.Id).NotEmpty();
            RuleFor(x => x.Name).NotEmpty();
            RuleFor(x => x.LastName).NotEmpty();
            RuleFor(x => x.Phone).NotEmpty();
            RuleFor(x => x.Email).EmailAddress().NotEmpty();
        }
    }
}
