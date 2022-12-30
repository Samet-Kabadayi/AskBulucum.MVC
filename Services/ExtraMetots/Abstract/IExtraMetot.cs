using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Services.ExtraMetots.Abstract
{
    public interface IExtraMetot
    {
        public string DoMD5HashedString(string password);
    }
}
