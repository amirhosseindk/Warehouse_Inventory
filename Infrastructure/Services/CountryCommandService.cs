using Application.IServices;
using Application.Services;
using Domain.Entities;
using Persistence.IServices;

namespace Infrastructure.Services
{
    public class CountryCommandService : GenericCommandServices<MadeInCountry>, ICountryCommandService
    {
        public CountryCommandService(IUnitOfWork unitOfWork)
            : base(unitOfWork)
        {
        }
    }
}
