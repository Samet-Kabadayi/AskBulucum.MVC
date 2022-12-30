using DataAccess.Repositories.Abstract;
using Entities.Concrete;

namespace DataAccess.Abstract
{
    public interface IAuthDalForSeeker : IAuthRepository<Seeker>
    {
    }
}
