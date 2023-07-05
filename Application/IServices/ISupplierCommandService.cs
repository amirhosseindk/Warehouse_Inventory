using Application.ViewModels.SupplierViewModels;

namespace Application.IServices
{
    public interface ISupplierCommandService
    {
        Task CreateSupplierAsync(SupVMCU sup , CancellationToken cancellationToken);
        Task UpdateSupplierAsync(SupVMCU sup , CancellationToken cancellationToken);
    }
}
