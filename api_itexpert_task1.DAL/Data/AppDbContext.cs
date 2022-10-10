using api_itexpert_task1.DAL.Entities;
using Microsoft.EntityFrameworkCore;

namespace api_itexpert_task1.DAL.Data
{
    public class AppDbContext : DbContext
    {
        public DbSet<CV> CVs { get; set; }
        public DbSet<Client> Clients { get; set; }
        public DbSet<ClientContacts> ClientContacts { get; set; }
        public DbSet<Dates> Dates { get; set; }
        public AppDbContext(DbContextOptions<AppDbContext> options) : base(options)
        {

        }
    }
}
