using Domain;
using Domain.Entities;

namespace Persistence.IServices
{
    public interface IUnitOfWork : IDisposable
    {
        IRepository<User> Users { get; }
        IRepository<Consumer> Consumers { get; }
        IRepository<Supplier> Suppliers { get; }
        Task<int> CompleteAsync(CancellationToken cancellationToken);
        IRepository<T> GetRepository<T>() where T : BaseEntity;
    }

}
