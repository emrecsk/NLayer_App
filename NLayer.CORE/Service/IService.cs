using System.Linq.Expressions;

namespace NLayer.CORE.Service
{
    public interface IService<T> where T : class
    {
        Task<T> GetByIdAsync(int id);
        Task<IEnumerable<T>> GetAllAsync();
        IQueryable<T> Where(Expression<Func<T, bool>> expression);
        Task<bool> AnyAsync(Expression<Func<T, bool>> expression);
        Task<T> AddAsync(T entity);//tek kayıt işlemi için
        Task<IEnumerable<T>> AddRangeAsync(IEnumerable<T> entities);//birden fazla kayıt için
        Task UpdateAsync(T entity);
        Task RemoveAsync(T entity);
        Task RemoveRangeAsync(IEnumerable<T> entities);
    }
}
