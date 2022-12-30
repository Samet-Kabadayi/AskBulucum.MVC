using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Services.Abstract
{
    public interface ITcKimlikService
    {
        Task<bool> IsPErson(string FirstName, string LastName, long Tc, int BirthDay);
    }
}
