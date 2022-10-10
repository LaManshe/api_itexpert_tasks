using api_itexpert_task1.DAL.Data;
using api_itexpert_task1.DAL.Entities;
using Microsoft.EntityFrameworkCore;

namespace api_itexpert_task1.DAL
{
    class ContactsRepository : Repository<ClientContacts>
    {
        private readonly AppDbContext _context;

        public override IQueryable<ClientContacts> Items => base.Items.Include(item => item.Client);

        public ContactsRepository(AppDbContext context) : base(context)
        {
            _context = context;
        }
    }
}
