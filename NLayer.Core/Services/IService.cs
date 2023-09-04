using System.Linq.Expressions;

namespace NLayer.Core.Services
{
    public interface IService<T> where T : class
    {
        Task<T> GetByIdAsync(int id);
        Task<IEnumerable<T>> GetAllAsync();
        IQueryable<T> Where(Expression<Func<T, bool>> expression);
        Task<bool> AnyAsync(Expression<Func<T, bool>> expression);

        Task<T> AddAsync(T entity);
        Task<IEnumerable<T>> AddRangeAsync(IEnumerable<T> entities);
        // service kısmında savchanges kullanacağımız için task yapıp async dönüştürdük
        Task UpdateAsync(T entity);// async yok uzun süren bir işlem değil
        Task RemoveAsync(T entity);// async yok 
        Task RemoveRangeAsync(IEnumerable<T> entities);
    }
}
