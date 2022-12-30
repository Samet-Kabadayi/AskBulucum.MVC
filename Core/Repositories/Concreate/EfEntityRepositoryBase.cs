using DataAccess.Repositories.Abstract;
using Core.Entities.Abstract;
using System.Linq.Expressions;
using System.Data.Entity;
using Microsoft.EntityFrameworkCore;

namespace DataAccess.Repositories.Concreate
{
    public class EfEntityRepositoryBase<TEntity, TContext> : IEntityRepository<TEntity>
    where TEntity : class, IEntity, new()
        where TContext : Microsoft.EntityFrameworkCore.DbContext, new()
    {
        public async Task<TEntity> AddAsync(TEntity entity)
        {
            using (TContext context = new())
            {
                await context.Set<TEntity>().AddAsync(entity);
              return entity;
            }
        }

        public async Task<bool> AnyAsync(Expression<Func<TEntity, bool>> predicate)
        {
            using (TContext context = new())
            {
                return await context.Set<TEntity>().AnyAsync(predicate);
            }
        }

        public async Task<int> CountAsync(Expression<Func<TEntity, bool>> predicate = null)
        {
            using (TContext context = new())
            {
                return await (predicate == null ? context.Set<TEntity>().CountAsync() : context.Set<TEntity>().CountAsync(predicate));
            }
        }

        public async Task DeleteAsync(TEntity entity)
        {
            using (TContext context = new())
            {
                await Task.Run(() => { context.Set<TEntity>().Remove(entity); });
            }
        }

        public async Task<IList<TEntity>> GetAllAsync(Expression<Func<TEntity, bool>> predicate = null, params Expression<Func<TEntity, object>>[] includeProperties)
        {
            using (TContext context = new())
            {
                IQueryable<TEntity> query = context.Set<TEntity>();
                if (predicate != null)
                {
                    query = query.Where(predicate);
                }

                if (includeProperties.Any())
                {
                    foreach (var includeProperty in includeProperties)
                    {
                        query = query.Include(includeProperty);
                    }
                }

                return await query.AsNoTracking()
                                  .ToListAsync();
            }
        }
               
        public IQueryable<TEntity> GetAsQueryable()
        {
            using (TContext context = new())
            {
                return context.Set<TEntity>().AsQueryable();
            }
        }

        public async Task<TEntity> GetAsync(Expression<Func<TEntity, bool>> predicate, params Expression<Func<TEntity, object>>[] includeProperties)
        {
            using (TContext context = new())
            {
                IQueryable<TEntity> query = context.Set<TEntity>();
                query = query.Where(predicate);

                if (includeProperties.Any())
                {
                    foreach (var includeProperty in includeProperties)
                    {
                        query = query.Include(includeProperty);
                    }
                }

                return await query.AsNoTracking().SingleOrDefaultAsync();
            }
        }

        public Task<TEntity> GetAsyncV2(IList<Expression<Func<TEntity, bool>>> predicates, IList<Expression<Func<TEntity, object>>> includeProperties)
        {
            throw new NotImplementedException();
        }

        public Task<IList<TEntity>> SearchAsync(IList<Expression<Func<TEntity, bool>>> predicates, params Expression<Func<TEntity, object>>[] includeProperties)
        {
            throw new NotImplementedException();
        }

        public Task<TEntity> UpdateAsync(TEntity entity)
        {
            throw new NotImplementedException();
        }
    }
}
//protected readonly BulucumMVCContext _context;

//public EfEntityRepositoryBase(BulucumMVCContext context)
//{
//    _context = context;
//    _context.ChangeTracker.QueryTrackingBehavior = QueryTrackingBehavior.NoTracking;
//}

//public async Task<IList<TEntity>> GetAllAsyncV2(IList<Expression<Func<TEntity, bool>>> predicates, IList<Expression<Func<TEntity, object>>> includeProperties)
//{
//    IQueryable<TEntity> query = _context.Set<TEntity>();
//    if (predicates != null && predicates.Any())
//    {
//        foreach (var predicate in predicates)
//        {
//            query = query.Where(predicate); // isActive==false && isDeleted==true
//        }
//    }

//    if (includeProperties != null && includeProperties.Any())
//    {
//        foreach (var includeProperty in includeProperties)
//        {
//            query = query.Include(includeProperty);
//        }
//    }

//    return await query.AsNoTracking().ToListAsync();
//}

//public async Task<TEntity> AddAsync(TEntity entity)
//{
//    await _context.Set<TEntity>().AddAsync(entity);
//    return entity;
//}

//public async Task<IList<TEntity>> SearchAsync(IList<Expression<Func<TEntity, bool>>> predicates, params Expression<Func<TEntity, object>>[] includeProperties)
//{
//    IQueryable<TEntity> query = _context.Set<TEntity>();
//    if (predicates.Any())
//    {
//        var predicateChain = PredicateBuilder.New<TEntity>();
//        foreach (var predicate in predicates)
//        {
//            predicate1 && predicate2 && predicate3 && predicateN
//             predicate1 || predicate2 || predicate3 || predicateN
//            predicateChain.Or(predicate);
//        }

//        query = query.Where(predicateChain);
//    }

//    if (includeProperties.Any())
//    {
//        foreach (var includeProperty in includeProperties)
//        {
//            query = query.Include(includeProperty);
//        }
//    }

//    return await query.AsNoTracking().ToListAsync();
//}

//public async Task<bool> AnyAsync(Expression<Func<TEntity, bool>> predicate)
//{
//    return await _context.Set<TEntity>().AnyAsync(predicate);
//}

//public async Task<int> CountAsync(Expression<Func<TEntity, bool>> predicate = null)
//{
//    return await (predicate == null ? _context.Set<TEntity>().CountAsync() : _context.Set<TEntity>().CountAsync(predicate));
//}

//public IQueryable<TEntity> GetAsQueryable()
//{
//    return _context.Set<TEntity>().AsQueryable();
//}

//public async Task DeleteAsync(TEntity entity)
//{
//    await Task.Run(() => { _context.Set<TEntity>().Remove(entity); });
//}

//public async Task<TEntity> GetAsyncV2(IList<Expression<Func<TEntity, bool>>> predicates, IList<Expression<Func<TEntity, object>>> includeProperties)
//{
//    IQueryable<TEntity> query = _context.Set<TEntity>();
//    if (predicates != null && predicates.Any())
//    {
//        foreach (var predicate in predicates)
//        {
//            query = query.Where(predicate); // isActive==false && isDeleted==true
//        }
//    }

//    if (includeProperties != null && includeProperties.Any())
//    {
//        foreach (var includeProperty in includeProperties)
//        {
//            query = query.Include(includeProperty);
//        }
//    }

//    return await query.AsNoTracking().SingleOrDefaultAsync();
//}

//public async Task<IList<TEntity>> GetAllAsync(Expression<Func<TEntity, bool>> predicate = null, params Expression<Func<TEntity, object>>[] includeProperties)
//{
//    IQueryable<TEntity> query = _context.Set<TEntity>();
//    if (predicate != null)
//    {
//        query = query.Where(predicate);
//    }

//    if (includeProperties.Any())
//    {
//        foreach (var includeProperty in includeProperties)
//        {
//            query = query.Include(includeProperty);
//        }
//    }

//    return await query.AsNoTracking().ToListAsync();
//}

//public async Task<TEntity> GetAsync(Expression<Func<TEntity, bool>> predicate, params Expression<Func<TEntity, object>>[] includeProperties)
//{
//    IQueryable<TEntity> query = _context.Set<TEntity>();
//    query = query.Where(predicate);

//    if (includeProperties.Any())
//    {
//        foreach (var includeProperty in includeProperties)
//        {
//            query = query.Include(includeProperty);
//        }
//    }

//    return await query.AsNoTracking().SingleOrDefaultAsync();
//}

//public async Task<TEntity> UpdateAsync(TEntity entity)
//{
//    await Task.Run(() => { _context.Set<TEntity>().Update(entity); });
//    return entity;
//}