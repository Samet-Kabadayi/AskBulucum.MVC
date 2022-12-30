using Core.Entities.Abstract;
using Entities.Concreate;

namespace Entities.Concrete
{
    public class VehicleType : EntityBase
    {   
        public string Name { get; set; }
        public ICollection<BrandVehicleType> Brands { get; set; }
    }
}
