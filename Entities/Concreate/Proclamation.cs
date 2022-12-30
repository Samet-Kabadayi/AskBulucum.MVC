using Core.Entities.Abstract;

namespace Entities.Concrete
{
    public class Proclamation : EntityBase
    {    
        public string Link { get; set; }
        public string Description { get; set; }
        public decimal ProclamaionPrize { get; set; }
        public decimal VehiclePrize { get; set; }     
        public Guid? CityId { get; set; }
        public City City { get; set; }
        public Guid? SeekerId { get; set; }
        public Seeker Seeker { get; set; }
        public Guid? BrandId { get; set; }
        public Brand Brand { get; set; }   

    }
}
