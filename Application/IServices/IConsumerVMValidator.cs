using Application.ViewModels.ConsumerViewModels;
using FluentValidation.Results;

namespace Application.IServices
{
    public interface IConsumerVMValidator
    {
        ValidationResult Validate(ConVMCU ConVM);
    }
}
