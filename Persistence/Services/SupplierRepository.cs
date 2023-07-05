using Domain.Entities;
using Persistence.IServices;

namespace Persistence.Services
{
    public class SupplierRepository : Repository<Supplier>, ISupplierRepository
    {
        public SupplierRepository(DatabaseContext context) : base(context)
        {
        }

    }
}
