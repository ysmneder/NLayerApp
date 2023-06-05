using System;
using System.Linq.Expressions;

namespace App.Core.Services
{

        public interface IGenericService<T> where T : class
        {
            Task<T> AddAsync(T entity);
            Task<IEnumerable<T>> AddRangeAsync(IEnumerable<T> entites);
            Task<IEnumerable<T>> GetAllAsync();
            Task<T> GetByIdAsync(Guid id);
            IQueryable<T> Where(Expression<Func<T, bool>> expression);
            Task<bool> AnyAsync(Expression<Func<T, bool>> expression);
            Task Update(T entity);
            Task UpdateRange(IEnumerable<T> entites);
            Task DeleteAsync(T entity);
            Task DeleteRangeAsync(IEnumerable<T> entites);

        }

}

