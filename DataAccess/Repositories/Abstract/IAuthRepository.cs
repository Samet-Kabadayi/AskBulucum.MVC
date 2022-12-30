using Core.Entities.Abstract;
using System.Linq.Expressions;

namespace DataAccess.Repositories.Abstract
{
    public interface IAuthRepository<T> where T : class, IAuth, new()
    {     
        Task<bool> IsExist (Expression<Func<T, bool>> predicate);
        Task<bool> CheckToLogin(Expression<Func<T, bool>> predicate);
    }
}
