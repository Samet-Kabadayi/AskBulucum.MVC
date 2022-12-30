using Bulucum.DataAccess.Abstract;
using DataAccess.Context;
using DataAccess.Repositories.Concreate;
using Entities.Concrete;
using Microsoft.EntityFrameworkCore;

namespace DataAccess.Concreate
{
    public class EfRoleDal : EfEntityRepositoryBase<Role>, IRoleDal
    {
        public EfRoleDal(BulucumMVCContext context) : base(context)
        {
        }
    }
}
