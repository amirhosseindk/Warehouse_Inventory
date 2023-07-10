using Domain.Entities;
using Persistence.IServices;

namespace Persistence.Services
{
    public class CountryRepository : Repository<MadeInCountry>, ICountryRepository
    {
        public CountryRepository(DatabaseContext context) : base(context)
        {
            
        }
    }
}
