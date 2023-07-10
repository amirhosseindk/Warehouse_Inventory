using Domain.Entities;
using Persistence.IServices;

namespace Persistence.Services
{
    public class MeasureRepository : Repository<UnitMeasure>, IMeasureRepository
    {
        public MeasureRepository(DatabaseContext context) : base(context)
        {
        }
    }
}
