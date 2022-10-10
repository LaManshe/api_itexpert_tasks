using api_itexpert_task1.DAL;
using api_itexpert_task1.DAL.Data;
using Microsoft.EntityFrameworkCore;

namespace api_itexpert_task1.Data
{
    static class DbRegistrator
    {
        public static IServiceCollection AddDatabase(this IServiceCollection services, IConfiguration configuration)
        {
            return services
            .AddDbContext<AppDbContext>(
                options => options.UseMySql(configuration.GetConnectionString("LocalCS_MySql"), new MySqlServerVersion(new Version(8, 0, 29))))
            .AddRepositoriesInDB()
            ;
        }
    }
}
