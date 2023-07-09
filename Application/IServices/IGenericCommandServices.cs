using Domain;

namespace Application.IServices
{
    public interface IGenericCommandServices<T> where T : BaseEntity
    {
        Task CreateAsync(T entity, CancellationToken cancellationToken);
        Task UpdateAsync(T entity, CancellationToken cancellationToken);
    }
}
