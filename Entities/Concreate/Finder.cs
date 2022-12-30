using Core.Entities.Abstract;


namespace Entities.Concrete
{
    public class Finder : EntityBase , IAuth
    {
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string Phone { get; set; }
        public string Email { get; set; }
        public string Tc { get; set; }
        public byte[] PasswordHash { get; set; }   
        public DateTime? DeletedDate { get; set; }
        public string? Description { get; set; }
        public bool VIP { get; set; } = false;
        public bool ConfirmEmail { get; set; } = false;
        public bool ConfirmPerson { get; set; } = false;   
        public bool IsBanned { get; set; } = false;
        public bool RememberMe { get; set; } = false;
        public int SuccessfulWork { get; set; } = 0;
        public decimal Vote { get; set; } = 0;
        public Guid? CityId { get; set; }
        public City? City { get; set; }
        public Guid? RoleId { get; set; }
        public Role? Role { get; set; }
 
    }
}
