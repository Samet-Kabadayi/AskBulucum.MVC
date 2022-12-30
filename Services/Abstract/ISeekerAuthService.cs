using Core.Results.Abstract;
using Entities.DTOs.Seeker;

namespace Services.Abstract
{
    public interface ISeekerAuthService
    {
        Task<IResult> IsExists(string eMail, string Tc, string phone);
        Task<IDataResult<SeekerLoginDto>> CheckLoginUser(string eMail, string hashedPassword);
        Task<IResult> CheckToMail(string eMail);
        
        Task<IResult> RegisterForSeeker(SeekerRegisterDto seekerRegisterDto,string password);
    }
}
