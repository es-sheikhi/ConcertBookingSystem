namespace ConcertBookingSystem.Application.Repositories.Common
{
    public interface IGenericRepository<T>
        where T : class
    {
        IEnumerable<T> GetAll();
        Task<IEnumerable<T>> GetAllAsync();
        T FindById(object id);
        Task<T> FindByIdAsync(object id);
        bool Add(T entity);
        Task<bool> AddAsync(T entity);
        bool Delete(T entity);
        Task<bool> DeleteAsync(T entity);
        bool DeleteRange(List<T> entities);
        Task<bool> DeleteRangeAsync(List<T> entities);
    }
}
