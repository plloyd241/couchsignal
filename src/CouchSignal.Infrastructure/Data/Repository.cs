using CouchSignal.Core.Interfaces;

namespace CouchSignal.Infrastructure.Data
{
    public class Repository<T> : IAsyncRepository<T>
    {
        protected readonly DeviceContext _context;

        public Repository(DeviceContext context)
        {
            _context = context;
        }

        public virtual async Task<T> FindAsync(int id)
        {
            return await _context.Set<T>().FindAsync(id);
        }

        public async Task<IReadOnlyList<T>> AllAsync()
        {
            return await _context.Set<T>().ToListAsync();
        }

        public async Task<int> CountAsync()
        {
            return await _context.Set<T>().CountAsync();
        }

        public async Task<T> AddAsync(T entity)
        {
            await _context.Set<T>().AddAsync(entity);
            await _context.SaveChangesAsync();

            return entity;
        }

        public async Task UpdateAsync(T entity)
        {
            _context.Entry(entity).State = EntityState.Modified;
            
            await _context.SaveChangesAsync();
        }

        public async Task DeleteAsync(T entity)
        {
            _context.Set<T>().Remove(entity);

            await _context.SaveChangesAsync();
        }
    }
}