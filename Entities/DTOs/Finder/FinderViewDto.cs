using Core.Entities.Abstract;
using Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entities.DTOs.Finder
{
    public class FinderViewDto : IDto
    {
        public string FirstName { get; set; }   
        public string? Description { get; set; }
        public int SuccessfulWork { get; set; } 
        public decimal Vote { get; set; }
        public string City { get; set; }
    }
}
