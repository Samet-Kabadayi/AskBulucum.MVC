using Bulucum.DataAccess.Abstract;
using DataAccess.Context;
using DataAccess.Repositories.Concreate;
using Entities.Concrete;
using Microsoft.EntityFrameworkCore;

namespace DataAccess.Concreate
{
    public class EfProclamationDal : EfEntityRepositoryBase<Proclamation>, IProclamationDal
    {
        public EfProclamationDal(BulucumMVCContext context) : base(context)
        {
        }
    }
}
