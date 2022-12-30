using DataAccess.Repositories.Concreate;
using DataAccess.Abstract;
using DataAccess.Context;
using DataAccess.Repositories.Concreate;
using Entities.Concrete;
using Microsoft.EntityFrameworkCore;

namespace DataAccess.Concreate
{
    public class EfBrandDal : EfEntityRepositoryBase<Brand>, IBrandDal
    {
        public EfBrandDal(BulucumMVCContext context) : base(context)
        {
        }
    }
}
