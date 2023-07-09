using Application.IServices;
using Domain;
using Persistence.IServices;

namespace Application.Services
{
    public class GenericServices<T> : IGenericServices<T> where T : BaseEntity
    {
        private readonly IRepository<T> _repository;
        private readonly IGenericCommandServices<T> _commandService;

        public GenericServices(IRepository<T> repository, IGenericCommandServices<T> commandService)
        {
            _repository = repository;
            _commandService = commandService;
        }

        public async Task<T> GetByIdAsync(Guid id, CancellationToken cancellationToken)
        {
            return await _repository.GetByIdAsync(id, cancellationToken);
        }

        public async Task<IEnumerable<T>> GetAllAsync(CancellationToken cancellationToken)
        {
            return await _repository.GetAllAsync(cancellationToken);
        }

        public async Task<T> CreateAsync(T entity, CancellationToken cancellationToken)
        {
            await _commandService.CreateAsync(entity, cancellationToken);
            return entity;
        }

        public async Task<T> UpdateAsync(T entity, CancellationToken cancellationToken)
        {
            await _commandService.UpdateAsync(entity, cancellationToken);
            return entity;
        }

        public async Task DeleteAsync(Guid id, CancellationToken cancellationToken)
        {
            await _repository.DeleteAsync(id, cancellationToken);
        }
    }
}
