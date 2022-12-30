using Bulucum.DataAccess.Abstract;
using Core.Results.Abstract;
using Core.Results.ComplexTypes;
using Core.Results.Concrete;
using Services.Abstract;

namespace Services.Concreate
{
    public class SeekerManager : ISeekerService
    {
        private readonly ISeekerDal _seekerDal;        
        public SeekerManager(ISeekerDal seekerDal)
        {
            _seekerDal = seekerDal;
        }

        public Task<IResult> ChangeConfirmPerson(string Tc)
        {
            throw new NotImplementedException();
        }

        //public async Task<IResult> ChangeConfirmPerson(string Tc)
        //{
        //    var seeker =await _seekerDal.GetAsync(x=>x.Tc==Tc);
        //    seeker.ConfirmPerson = true; 
        //    _unitOfWork.Seekers.UpdateAsync(seeker);
        //    return new Result(ResultStatus.Success);

        //}
    }
}
