using Application.ViewModels.ConsumerViewModels;
using Application.ViewModels.SupplierViewModels;
using Application.ViewModels.UserViewModels;
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
            TypeAdapterConfig<User, UserVMCU>.NewConfig();
            TypeAdapterConfig<UserVMCU, User>.NewConfig();
            TypeAdapterConfig<Supplier, SupVMCU>.NewConfig();
            TypeAdapterConfig<SupVMCU, Supplier>.NewConfig();
            TypeAdapterConfig<Consumer, ConVMCU>.NewConfig();
            TypeAdapterConfig<ConVMCU, Consumer>.NewConfig();
        }
    }
}
