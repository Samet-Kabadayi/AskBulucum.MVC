using Core.Entities.Abstract;

namespace Entities.Concrete
{
    public class Seeker : EntityBase, IAuth
    {
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string Phone { get; set; }
        public string Email { get; set; }
        public string Tc { get; set; }
        public byte[] PasswordHash { get; set; }
        public bool ConfirmEmail { get; set; } = false;
        public bool ConfirmPerson { get; set; } = false;
        public bool IsBanned { get; set; } = false;
        public bool VIP { get; set; } = false;
        public bool RememberMe { get; set; } = false;
        public Guid? CityId { get; set; }
        public City? City { get; set; }
        public ICollection<Proclamation>? Proclamations { get; set; }
      
    }
}
