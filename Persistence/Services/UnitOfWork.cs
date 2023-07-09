using Domain.Entities;
using Persistence.IServices;

namespace Persistence.Services
{
    public class UnitOfWork : IUnitOfWork,IDisposable
    {
        private readonly DatabaseContext _context;

        public IRepository<User> Users { get; private set; }
        public IRepository<Consumer> Consumers { get; private set; }
        public IRepository<Supplier> Suppliers { get; private set; }

        public UnitOfWork(DatabaseContext context)
        {
            _context = context;
            Users = new Repository<User>(_context);
            Consumers = new ConsumerRepository(_context);
            Suppliers = new SupplierRepository(_context);
        }

        public async Task<int> CompleteAsync(CancellationToken cancellationToken)
        {
            return await _context.SaveChangesAsync(cancellationToken);
        }

        public IRepository<T> GetRepository<T>() where T : Domain.BaseEntity
        {
            return new Repository<T>(_context);
        }

        public void Dispose()
        {
            _context.Dispose();
        }
    }

}
