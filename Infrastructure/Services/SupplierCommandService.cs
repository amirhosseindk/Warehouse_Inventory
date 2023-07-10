using Application.IServices;
using Application.Services;
using Domain.Entities;
using Persistence.IServices;

namespace Infrastructure.Services
{
    public class SupplierCommandService : GenericCommandServices<Supplier>, ISupplierCommandService
    {
        public SupplierCommandService(IUnitOfWork unitOfWork)
            : base(unitOfWork)
        {
        }
    }
}
