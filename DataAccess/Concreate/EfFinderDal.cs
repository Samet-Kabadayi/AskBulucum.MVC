using Bulucum.DataAccess.Abstract;
using DataAccess.Context;
using DataAccess.Repositories.Concreate;
using Entities.Concrete;
using Microsoft.EntityFrameworkCore;

namespace DataAccess.Concreate
{
    public class EfFinderDal : EfEntityRepositoryBase<Finder>, IFinderDal
    {
        public EfFinderDal(BulucumMVCContext context) : base(context)
        {
        }
    }
}
