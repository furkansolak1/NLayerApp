﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

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
