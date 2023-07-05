using Application.ViewModels.SupplierViewModels;
using FluentValidation.Results;

namespace Application.IServices
{
    public interface ISupplierVMValidator
    {
        ValidationResult Validate(SupVMCU SupVM);
    }
}
