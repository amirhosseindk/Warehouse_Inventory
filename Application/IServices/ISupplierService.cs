using Application.ViewModels.SupplierViewModels;

namespace Application.IServices
{
    public interface ISupplierService
    {
        Task<SupVMCU> GetSupplierByIdAsync(SupVMCU supVMId, CancellationToken cancellationToken);
        Task<IEnumerable<SupVMCU>> GetSuppliersAsync(CancellationToken cancellationToken);
        Task<SupVMCU> CreateSupplierAsync(SupVMCU supVMId, CancellationToken cancellationToken);
        Task<SupVMCU> UpdateSupplierAsync(SupVMCU supVMId, CancellationToken cancellationToken);
        Task DeleteSupplierAsync(SupVMCU supVMId, CancellationToken cancellationToken);
    }
}
