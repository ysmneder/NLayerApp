using System;
using System.Linq.Expressions;
using App.Core.Repositories;
using App.Core.Services;
using App.Core.UnitOfWork;
using App.Repository.Repositories;
using App.Services.Exceptions;
using Microsoft.EntityFrameworkCore;

namespace App.Service.Services
{
    public class Service<T> : IGenericService<T> where T : class
    {
        private readonly IGenericRepository<T> _repository;
        private readonly IUnitOfWork _unitOfWork;

        public Service(IGenericRepository<T> repository, IUnitOfWork unitOfWork)
        {
            _repository = repository;
            _unitOfWork = unitOfWork;

        }
        public async Task<T> AddAsync(T entity)
        {
            await _repository.AddAsync(entity);
            await _unitOfWork.CommitAsync();
            return entity;
        }

        public async Task<IEnumerable<T>> AddRangeAsync(IEnumerable<T> entites)
        {
            await _repository.AddRangeAsync(entites);
            await _unitOfWork.CommitAsync();
            return entites;
        }

        public async Task<bool> AnyAsync(Expression<Func<T, bool>> expression)
        {
            return await _repository.AnyAsync(expression);
        }

        public async Task DeleteAsync(T entity)
        {
            _repository.Delete(entity);
            await _unitOfWork.CommitAsync();
        }

        public async Task DeleteRangeAsync(IEnumerable<T> entites)
        {
            _repository.DeleteRange(entites);
            await _unitOfWork.CommitAsync();
        }

        public async Task<IEnumerable<T>> GetAllAsync()
        {
            return await _repository.GetAll().ToListAsync();
        }

        public async Task<T> GetByIdAsync(Guid id)
        {
            var hasId = await _repository.GetByIdAsync(id);

            return hasId == null ? throw new NotFoundException($"{typeof(T).Name}({id}) not found") : hasId;
        }

        public async Task Update(T entity)
        {
            _repository.Update(entity);
            await _unitOfWork.CommitAsync();
        }

        public async Task UpdateRange(IEnumerable<T> entites)
        {
            _repository.UpdateRange(entites);
            await _unitOfWork.CommitAsync();
        }

        public IQueryable<T> Where(Expression<Func<T, bool>> expression)
        {
            return _repository.Where(expression);
        }

    }
}

