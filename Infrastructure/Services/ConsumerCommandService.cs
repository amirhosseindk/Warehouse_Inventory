using Application.IServices;
using Application.Services;
using Domain.Entities;
using Persistence.IServices;

namespace Infrastructure.Services
{
    public class ConsumerCommandService : GenericCommandServices<Consumer>, IConsumerCommandService
    {
        public ConsumerCommandService(IUnitOfWork unitOfWork)
            : base(unitOfWork)
        {
        }
    }
}
