using Application.IServices;
using Application.ViewModels.SupplierViewModels;
using Domain.Entities;
using FluentValidation;
using Mapster;
using Persistence.IServices;

namespace Infrastructure.Services
{
    public class SupplierCommandService : ISupplierCommandService
    {
        private readonly IUnitOfWork _unitOfWork;
        private readonly IValidator<SupVMCU> _validator;

        public SupplierCommandService(IUnitOfWork unitOfWork , IValidator<SupVMCU> validator)
        {
            _unitOfWork = unitOfWork;
            _validator = validator;
        }

        public async Task CreateSupplierAsync(SupVMCU sup , CancellationToken cancellationToken)
        {
            var validationResult = await _validator.ValidateAsync(sup, cancellationToken);
            if (!validationResult.IsValid)
            {
                throw new FluentValidation.ValidationException(validationResult.Errors);
            }

            var sups = sup.Adapt<Supplier>();

            try
            {
                await _unitOfWork.Suppliers.CreateAsync(sups, cancellationToken);
                await _unitOfWork.CompleteAsync(cancellationToken);
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public async Task UpdateSupplierAsync(SupVMCU sup , CancellationToken cancellationToken)
        {
            var validationResult = await _validator.ValidateAsync(sup, cancellationToken);
            if (!validationResult.IsValid)
            {
                throw new FluentValidation.ValidationException(validationResult.Errors);
            }

            var sups = sup.Adapt<Supplier>();

            try
            {
                await _unitOfWork.Suppliers.UpdateAsync(sups, cancellationToken);
                await _unitOfWork.CompleteAsync(cancellationToken);
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

    }
}
