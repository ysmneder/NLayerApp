using System;
using System.Linq.Expressions;

namespace App.Core.Repositories
{
	public interface  IGenericRepository<T> where T: class
	{
		Task<T> AddAsync(T entity);
		Task<IEnumerable<T>> AddRangeAsync(IEnumerable<T> entites);
		IQueryable<T> GetAll();
		Task<T> GetByIdAsync(Guid id);
		IQueryable<T> Where(Expression<Func<T,bool>> expression);
		Task<bool> AnyAsync(Expression<Func<T, bool>> expression);
		void Update(T entity);
		void UpdateRange(IEnumerable<T> entites);
		void Delete(T entity);
		void DeleteRange(IEnumerable<T> entites);

	}
}

