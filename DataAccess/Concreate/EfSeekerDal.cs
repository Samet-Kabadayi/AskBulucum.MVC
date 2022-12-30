using Bulucum.DataAccess.Abstract;
using DataAccess.Context;
using DataAccess.Repositories.Concreate;
using Entities.Concrete;
using Microsoft.EntityFrameworkCore;

namespace DataAccess.Concreate
{
    public class EfSeekerDal : EfEntityRepositoryBase<Seeker>, ISeekerDal
    {
        public EfSeekerDal(BulucumMVCContext context) : base(context)
        {
        }
    }
}
