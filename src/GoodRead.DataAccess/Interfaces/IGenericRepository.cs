namespace GoodRead.DataAccess.Interfaces
{
    public interface IGenericRepository<T> where T : class
    {
        Task<T> CreateAsync(T entity);
        Task<T> UpdateAsync(long id, T entity);
        Task<T> DeleteAsync(long id);
        Task<T> GetAsync(long id);

    }
}
