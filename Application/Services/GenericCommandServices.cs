using Application.IServices;
using Domain;
using Persistence.IServices;

namespace Application.Services
{
    public class GenericCommandServices<T> : IGenericCommandServices<T> where T : BaseEntity
    {
        private readonly IUnitOfWork _unitOfWork;

        public GenericCommandServices(IUnitOfWork unitOfWork)
        {
            _unitOfWork = unitOfWork;
        }

        public async Task CreateAsync(T entity, CancellationToken cancellationToken)
        {
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
