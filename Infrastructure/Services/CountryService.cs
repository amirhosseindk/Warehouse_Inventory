﻿using Application.IServices;
using Application.Services;
using Domain.Entities;
using Persistence.IServices;

namespace Infrastructure.Services
{
    public class CountryService : GenericServices<MadeInCountry> , ICountryService
    {
        public CountryService(ICountryRepository repository, IGenericCommandServices<MadeInCountry> commandService)
            : base(repository, commandService)
        {
            
        }
    }
}
