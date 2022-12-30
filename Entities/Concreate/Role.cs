using Core.Entities.Abstract;

namespace Entities.Concrete
{
    public class Role : EntityBase
    {   
        public string Name { get; set; }
        public ICollection<Finder> Finders { get; set; }
    }
}
