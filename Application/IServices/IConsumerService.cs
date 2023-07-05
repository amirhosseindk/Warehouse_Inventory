using Application.ViewModels.ConsumerViewModels;

namespace Application.IServices
{
    public interface IConsumerService
    {
        Task<ConVMCU> GetConsumerByIdAsync(ConVMCU conVMId, CancellationToken cancellationToken);
        Task<IEnumerable<ConVMCU>> GetConsumersAsync(CancellationToken cancellationToken);
        Task<ConVMCU> CreateConsumerAsync(ConVMCU conVM, CancellationToken cancellationToken);
        Task<ConVMCU> UpdateConsumerAsync(ConVMCU conVM, CancellationToken cancellationToken);
        Task DeleteConsumerAsync(ConVMCU conVMId, CancellationToken cancellationToken);
    }
}
