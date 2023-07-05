using Application.ViewModels.ConsumerViewModels;

namespace Application.IServices
{
    public interface IConsumerCommandService
    {
        Task CreateConsumerAsync(ConVMCU con , CancellationToken cancellationToken);
        Task UpdateConsumerAsync(ConVMCU con , CancellationToken cancellationToken);
    }
}
