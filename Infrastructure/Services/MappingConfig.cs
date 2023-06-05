﻿using Application.ViewModels;
using Domain.Entities;
using Mapster;

namespace Infrastructure.Services
{
    public static class MappingConfig
    {
        public static void ConfigureMappings()
        {
            TypeAdapterConfig.GlobalSettings
                .Default.PreserveReference(true)
                .ShallowCopyForSameType(true);
            TypeAdapterConfig<User, UserViewModel>.NewConfig();
            TypeAdapterConfig<UserViewModel, User>.NewConfig();
        }
    }
}
