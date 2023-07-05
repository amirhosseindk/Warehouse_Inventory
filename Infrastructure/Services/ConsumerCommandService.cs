using Application.IServices;
using Application.ViewModels.ConsumerViewModels;
using Domain.Entities;
using FluentValidation;
using Mapster;
using Persistence.IServices;

namespace Infrastructure.Services
{
    public class ConsumerCommandService : IConsumerCommandService
    {
        private readonly IUnitOfWork _unitOfWork;
        private readonly IValidator<ConVMCU> _validator;

        public ConsumerCommandService(IUnitOfWork unitOfWork , IValidator<ConVMCU> validator)
        {
            _unitOfWork = unitOfWork;
            _validator = validator;
        }

        public async Task CreateConsumerAsync(ConVMCU con , CancellationToken cancellationToken)
        {
            var validationResult = await _validator.ValidateAsync(con, cancellationToken);
            if (!validationResult.IsValid)
            {
                throw new FluentValidation.ValidationException(validationResult.Errors);
            }
            
            var cons = con.Adapt<Consumer>();

            try
            {
                await _unitOfWork.Consumers.CreateAsync(cons, cancellationToken);
                await _unitOfWork.CompleteAsync(cancellationToken);
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public async Task UpdateConsumerAsync(ConVMCU con , CancellationToken cancellationToken)
        {
            var validationResult = await _validator.ValidateAsync(con, cancellationToken);
            if (!validationResult.IsValid)
            {
                throw new FluentValidation.ValidationException(validationResult.Errors);
            }

            var cons = con.Adapt<Consumer>();

            try
            {
                await _unitOfWork.Consumers.UpdateAsync(cons, cancellationToken);
                await _unitOfWork.CompleteAsync(cancellationToken);
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

    }
}
