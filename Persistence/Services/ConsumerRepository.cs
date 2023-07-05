using Domain.Entities;
using Persistence.IServices;

namespace Persistence.Services
{
    public class ConsumerRepository : Repository<Consumer>, IConsumerRepository
    {
        public ConsumerRepository(DatabaseContext context) : base(context)
        {
        }

    }
}
