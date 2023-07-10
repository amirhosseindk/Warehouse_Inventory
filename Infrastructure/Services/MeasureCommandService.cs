using Application.IServices;
using Application.Services;
using Domain.Entities;
using Persistence.IServices;

namespace Infrastructure.Services
{
    public class MeasureCommandService : GenericCommandServices<UnitMeasure>, IMeasureCommandService
    {
        public MeasureCommandService(IUnitOfWork unitOfWork)
            : base(unitOfWork)
        {
        }
    }
}
