using Core.Entities.Abstract;
using Entities.Concreate;

namespace Entities.Concrete
{
    public class Brand : EntityBase
    {    
        public string Name { get; set; }
        public ICollection<Proclamation> Proclamations { get; set; }
        public ICollection<BrandVehicleType> VehicleTypes { get; set; }
    }
}
