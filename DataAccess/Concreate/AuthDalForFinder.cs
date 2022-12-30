using DataAccess.Repositories.Concreate;
using DataAccess.Abstract;
using DataAccess.Context;
using Entities.Concrete;

namespace DataAccess.Concreate
{
    public class AuthDalForFinder : AuthRepository<Finder,BulucumMVCContext>,IAuthDalForrFinder
    {
    }
}
