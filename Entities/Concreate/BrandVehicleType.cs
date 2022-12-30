using Core.Entities.Abstract;
using Entities.Concrete;


namespace Entities.Concreate
{
    public class BrandVehicleType : IEntity
    {
        public Guid BrandId { get; set; }
        public Guid VehicleTypeId { get; set; }
        public VehicleType VehicleType { get; set; }
        public Brand Brand { get; set; }
    }
}
