using Bulucum.DataAccess.Abstract;
using DataAccess.Context;
using DataAccess.Repositories.Concreate;
using Entities.Concrete;
using Microsoft.EntityFrameworkCore;

namespace DataAccess.Concreate
{
    public class EfVehicleTypeDal : EfEntityRepositoryBase<VehicleType>, IVehicleTypeDal
    {
        public EfVehicleTypeDal(BulucumMVCContext context) : base(context)
        {
        }
    }
}
