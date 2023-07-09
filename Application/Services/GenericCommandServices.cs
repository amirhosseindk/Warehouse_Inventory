using Application.IServices;
using Domain;
using FluentValidation;
using Persistence.IServices;

namespace Application.Services
{
    public class GenericCommandServices<T> : IGenericCommandServices<T> where T : BaseEntity
    {
        private readonly IUnitOfWork _unitOfWork;
        private readonly IValidator<T> _validator;

        public GenericCommandServices(IUnitOfWork unitOfWork, IValidator<T> validator)
        {
            _unitOfWork = unitOfWork;
            _validator = validator;
        }

        public async Task CreateAsync(T entity, CancellationToken cancellationToken)
        {
            var validationResult = await _validator.ValidateAsync(entity, cancellationToken);
            if (!validationResult.IsValid)
            {
                throw new FluentValidation.ValidationException(validationResult.Errors);
            }

            try
            {
                await _unitOfWork.GetRepository<T>().CreateAsync(entity, cancellationToken);
                await _unitOfWork.CompleteAsync(cancellationToken);
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public async Task UpdateAsync(T entity, CancellationToken cancellationToken)
        {
            var validationResult = await _validator.ValidateAsync(entity, cancellationToken);
            if (!validationResult.IsValid)
            {
                throw new FluentValidation.ValidationException(validationResult.Errors);
            }

            try
            {
                await _unitOfWork.GetRepository<T>().UpdateAsync(entity, cancellationToken);
                await _unitOfWork.CompleteAsync(cancellationToken);
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
    }
}
