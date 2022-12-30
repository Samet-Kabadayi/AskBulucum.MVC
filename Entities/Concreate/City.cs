using Core.Entities.Abstract;

namespace Entities.Concrete
{
    public class City : EntityBase
    {
        public string Name { get; set; }
        public ICollection<Seeker> Seekers { get; set; }
        public ICollection<Finder> Finders { get; set; }
        public ICollection<Proclamation> Proclamations { get; set; }
    }
}
