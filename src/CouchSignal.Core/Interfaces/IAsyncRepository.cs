namespace CouchSignal.Core.Interfaces
{
    public interface IAsyncRepository<T>
    {
        Task<T> FindAsync(int id);
        Task<IReadOnlyList<T>> AllAsync();
        Task<T> AddAsync(T entity);
        Task UpdateAsync(T entity);
        Task DeleteAsync(T entity);
        Task<int> CountAsync();
    }
}