namespace Core.Entities.Abstract
{
    public interface IAuth
    {
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string Phone { get; set; }
        public string Email { get; set; }
        public string Tc { get; set; }

    }
}
