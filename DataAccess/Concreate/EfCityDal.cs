using DataAccess.Repositories.Concreate;
using DataAccess.Abstract;
using DataAccess.Repositories.Concreate;
using Entities.Concrete;
using Microsoft.EntityFrameworkCore;
using DataAccess.Context;

namespace DataAccess.Concreate
{
    public class EfCityDal : EfEntityRepositoryBase<City>, ICityDal
    {
        public EfCityDal(BulucumMVCContext context) : base(context)
        {
        }
    }
}
