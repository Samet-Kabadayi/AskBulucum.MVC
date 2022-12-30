﻿using Core.Entities.Abstract;
using System.Linq.Expressions;


namespace DataAccess.Repositories.Abstract
{
    public interface IEntityRepository<T> where T : class, IEntity, new()
    {
        Task<T> GetAsync(Expression<Func<T, bool>> predicate, params Expression<Func<T, object>>[] includeProperties); // var kullanici = repository.GetAsync(k=>k.Id==15);
        Task<T> GetAsyncV2(IList<Expression<Func<T, bool>>> predicates, IList<Expression<Func<T, object>>> includeProperties);
        // if(isActive==true) predicates.Add()

        Task<IList<T>> GetAllAsync(Expression<Func<T, bool>> predicate = null,
            params Expression<Func<T, object>>[] includeProperties);
        Task<IList<T>> GetAllAsyncV2(IList<Expression<Func<T, bool>>> predicates, IList<Expression<Func<T, object>>> includeProperties);

        Task<T> AddAsync(T entity);
        Task<T> UpdateAsync(T entity);
        Task DeleteAsync(T entity);

        Task<IList<T>> SearchAsync(IList<Expression<Func<T, bool>>> predicates,
            params Expression<Func<T, object>>[] includeProperties);
        Task<bool> AnyAsync(Expression<Func<T, bool>> predicate);
        Task<int> CountAsync(Expression<Func<T, bool>> predicate = null);

        IQueryable<T> GetAsQueryable();
    }
}
