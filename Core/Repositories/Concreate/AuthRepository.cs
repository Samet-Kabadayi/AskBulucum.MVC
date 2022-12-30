using DataAccess.Repositories.Abstract;
using Core.Entities.Abstract;
using Microsoft.EntityFrameworkCore;
using System.Linq.Expressions;

namespace DataAccess.Repositories.Concreate
{
    public class AuthRepository<TAuth, TContext> : IAuthRepository<TAuth>
        where TAuth : class, IAuth, new()
        where TContext : DbContext, new()
    {
        public async Task<bool> CheckToLogin(Expression<Func<TAuth, bool>> predicate)
        {
            using (TContext context = new())
            {
                return await context.Set<TAuth>().AnyAsync(predicate);
            }
        }

        public async Task<bool> IsExist(Expression<Func<TAuth, bool>> predicate)
        {
            using (TContext context = new())
            {
                return await context.Set<TAuth>().AnyAsync(predicate);
            }
        }
    }
}
