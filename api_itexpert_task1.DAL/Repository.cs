using api_itexpert_task1.DAL.Data;
using api_itexpert_task1.DAL.Entities.Base;
using api_itexpert_task1.Interfaces;
using Microsoft.EntityFrameworkCore;

namespace api_itexpert_task1.DAL
{
    internal class Repository<T> : IRepository<T>
        where T : Entity, new()
    {

        private readonly DbSet<T> _Set;
        private readonly AppDbContext _context;

        public Repository(AppDbContext context)
        {
            _context = context;
            _Set = context.Set<T>();
        }

        public virtual IQueryable<T> Items => _Set;

        public T Add(T item)
        {
            if (item is null) throw new ArgumentNullException(nameof(item));

            _context.Entry(item).State = EntityState.Added;
            _context.SaveChanges();
            return item;
        }

        public async Task<T> AddAsync(T item, CancellationToken Cancel = default)
        {
            _context.Entry(item).State = EntityState.Added;
            await _context.SaveChangesAsync(Cancel).ConfigureAwait(false);
            return item;
        }

        public void Clear()
        {
            _context.RemoveRange(Items);
            _context.SaveChanges();
        }

        public T Get(int id)
        {
            throw new NotImplementedException();
        }

        public Task<T> GetAsync(int id, CancellationToken Cancel = default)
        {
            throw new NotImplementedException();
        }

        public void Remove(int id)
        {
            throw new NotImplementedException();
        }

        public Task RemoveAsync(int id, CancellationToken Cancel = default)
        {
            throw new NotImplementedException();
        }

        public void Update(T item)
        {
            throw new NotImplementedException();
        }

        public Task UpdateAsync(T item, CancellationToken Cancel = default)
        {
            throw new NotImplementedException();
        }
    }
}
