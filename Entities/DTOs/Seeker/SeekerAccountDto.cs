using Core.Entities.Abstract;
using Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entities.DTOs.Seeker
{
    public class SeekerAccountDto : IDto
    {
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string Phone { get; set; }
        public string Email { get; set; }
        public string Tc { get; set; }      
        public bool ConfirmEmail { get; set; }
        public bool ConfirmPerson { get; set; }
        public bool IsBanned { get; set; } = false;
        public bool VIP { get; set; } = false;
        public bool RememberMe { get; set; } = false;
        public Guid CityId { get; set; }
        public City City { get; set; }
    }
}
