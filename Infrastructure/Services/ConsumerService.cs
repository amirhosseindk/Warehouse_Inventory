using Application.IServices;
using Application.ViewModels.ConsumerViewModels;
using Mapster;
using Persistence.IServices;

namespace Infrastructure.Services
{
    public class ConsumerService : IConsumerService
    {
        private readonly IConsumerRepository _consumerRepository;
        private readonly IConsumerCommandService _commandService;

        public ConsumerService(IConsumerRepository repository , IConsumerCommandService commandService)
        {
            _commandService = commandService;
            _consumerRepository = repository;
        }

        public async Task<ConVMCU> CreateConsumerAsync(ConVMCU conVM, CancellationToken cancellationToken)
        {
            await _commandService.CreateConsumerAsync(conVM, cancellationToken);
            return conVM;
        }

        public async Task DeleteConsumerAsync(ConVMCU conVMId, CancellationToken cancellationToken)
        {
            await _consumerRepository.DeleteAsync(conVMId.Id, cancellationToken);
        }

        public async Task<ConVMCU> GetConsumerByIdAsync(ConVMCU conVMId, CancellationToken cancellationToken)
        {
            var con = await _consumerRepository.GetByIdAsync(conVMId.Id, cancellationToken);
            return con.Adapt<ConVMCU>();
        }

        public async Task<IEnumerable<ConVMCU>> GetConsumersAsync(CancellationToken cancellationToken)
        {
            var cons = await _consumerRepository.GetAllAsync(cancellationToken);
            return cons.Adapt<IEnumerable<ConVMCU>>();
        }

        public async Task<ConVMCU> UpdateConsumerAsync(ConVMCU conVM, CancellationToken cancellationToken)
        {
            await _commandService.UpdateConsumerAsync(conVM, cancellationToken);
            return conVM;
        }
    }
}
