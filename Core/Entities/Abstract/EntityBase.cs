
namespace Core.Entities.Abstract
{
    public abstract class EntityBase : IEntity
    {
        public virtual Guid Id { get; set; }
        public virtual DateTime CreatedDate { get; set; } = DateTime.Now;
        public virtual DateTime? ModifiedDate { get; set; } = DateTime.Now;
        public virtual DateTime? DeletedDate { get; set; }
        public virtual bool IsActive { get; set; } = true;
        public virtual string CreatedByName { get; set; } = "empty";
        public virtual string? ModifiedByName { get; set; } = "empty";       
    }
}
