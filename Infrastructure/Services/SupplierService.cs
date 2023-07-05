using Application.IServices;
using Application.ViewModels.SupplierViewModels;
using Mapster;
using Persistence.IServices;

namespace Infrastructure.Services
{
    public class SupplierService : ISupplierService
    {
        private readonly ISupplierRepository _SupplierRepository;
        private readonly ISupplierCommandService _commandService;

        public SupplierService(ISupplierRepository repository, ISupplierCommandService commandService)
        {
            _commandService = commandService;
            _SupplierRepository = repository;
        }

        public async Task<SupVMCU> CreateSupplierAsync(SupVMCU supVM, CancellationToken cancellationToken)
        {
            await _commandService.CreateSupplierAsync(supVM, cancellationToken);
            return supVM;
        }

        public async Task DeleteSupplierAsync(SupVMCU supVMId, CancellationToken cancellationToken)
        {
            await _SupplierRepository.DeleteAsync(supVMId.Id, cancellationToken);
        }

        public async Task<SupVMCU> GetSupplierByIdAsync(SupVMCU supVMId, CancellationToken cancellationToken)
        {
            var con = await _SupplierRepository.GetByIdAsync(supVMId.Id, cancellationToken);
            return con.Adapt<SupVMCU>();
        }

        public async Task<IEnumerable<SupVMCU>> GetSuppliersAsync(CancellationToken cancellationToken)
        {
            var cons = await _SupplierRepository.GetAllAsync(cancellationToken);
            return cons.Adapt<IEnumerable<SupVMCU>>();
        }

        public async Task<SupVMCU> UpdateSupplierAsync(SupVMCU supVM, CancellationToken cancellationToken)
        {
            await _commandService.UpdateSupplierAsync(supVM, cancellationToken);
            return supVM;
        }
    }
}
