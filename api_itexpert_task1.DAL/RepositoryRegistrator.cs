using api_itexpert_task1.DAL.Entities;
using api_itexpert_task1.Interfaces;
using Microsoft.Extensions.DependencyInjection;

namespace api_itexpert_task1.DAL
{
    public static class RepositoryRegistrator
    {
        public static IServiceCollection AddRepositoriesInDB(this IServiceCollection services) => services
            .AddTransient<IRepository<CV>, Repository<CV>>()
            .AddTransient<IRepository<ClientContacts>, ContactsRepository>()
            .AddTransient<IRepository<Client>, Repository<Client>>()
            .AddTransient<IRepository<Dates>, Repository<Dates>>()
        ;
    }
}
