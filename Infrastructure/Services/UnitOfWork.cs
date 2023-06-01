using Application.IServices;
using Persistence;
using Persistence.Repositories;

namespace Infrastructure.Services
{
    public class UnitOfWork : IUnitOfWork
    {
        private readonly DatabaseContext _context;
        public IUserRepository Users { get; private set; }

        public UnitOfWork(DatabaseContext context)
        {
            _context = context;
            Users = new UserRepository(_context);
        }

        public async Task<int> CompleteAsync(CancellationToken cancellationToken)
        {
            return await _context.SaveChangesAsync(cancellationToken);
        }

        public void Dispose()
        {
            _context.Dispose();
        }
    }

}
