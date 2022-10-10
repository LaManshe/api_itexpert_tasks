using api_itexpert_task1.Data;
using api_itexpert_task1.Models;
using api_itexpert_task1.Models.Mapping;
using api_itexpert_task1.Services.Interfaces;

namespace api_itexpert_task1.Services
{
    static class ServicesRegistrator
    {
        public static IServiceCollection AddServices(this IServiceCollection services) => services
            .AddTransient<ISortManager, Sorter>()
            .AddTransient<IDbManager, DbManager>()
            .AddAutoMapper(typeof(ModelsMappingProfile))
            .AddTransient<IClientDbManager, ClientDbManager>()
            .AddTransient<IDateDbManager, DatesDbManager>()
        ;
    }
}
