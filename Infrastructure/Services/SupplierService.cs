using Application.IServices;
using Application.Services;
using Domain.Entities;
using Persistence.IServices;

namespace Infrastructure.Services
{
    public class SupplierService : GenericServices<Supplier>, ISupplierService
    {
        public SupplierService(ISupplierRepository repository, IGenericCommandServices<Supplier> commandService)
            : base(repository, commandService)
        {
        }
    }
}
