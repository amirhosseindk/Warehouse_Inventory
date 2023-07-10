using Application.IServices;
using Application.Services;
using Domain.Entities;
using Persistence.IServices;

namespace Infrastructure.Services
{
    public class SupplierService : GenericServices<Supplier>, ISupplierService
    {
        public SupplierService(ISupplierRepository repository, ISupplierCommandService commandService)
            : base(repository, commandService)
        {
        }
    }
}
