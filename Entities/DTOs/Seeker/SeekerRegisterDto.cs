using Core.Entities.Abstract;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entities.DTOs.Seeker
{
    public class SeekerRegisterDto : IDto
    {     
        public string FirstName { get; set; }      
        public string LastName { get; set; }
        public string Phone { get; set; }    
        public string TC { get; set; }
        public string Email { get; set; }         
    }
}
