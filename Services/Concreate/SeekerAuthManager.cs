using Bulucum.DataAccess.Abstract;
using Core.Results.Abstract;
using Core.Results.ComplexTypes;
using Core.Results.Concrete;
using Entities.Concrete;
using Entities.DTOs.Seeker;
using Services.Abstract;
using Services.ExtraMetots.Abstract;
using Services.Utilities;
using System.Text;

namespace Services.Concreate
{
    public class SeekerAuthManager : ISeekerAuthService
    {

        private readonly IExtraMetot _extraMetot;
        private readonly ISeekerDal _seekerDal;
        public SeekerAuthManager(IExtraMetot extraMetot, ISeekerDal seekerDal)
        {
            _extraMetot = extraMetot;
            _seekerDal = seekerDal;
        }

        public async Task<IDataResult<SeekerLoginDto>> CheckLoginUser(string eMail, string hashedPassword)
        {
           
          
           var result = _seekerDal.GetAsync(x => x.Email == eMail && x.PasswordHash.ToString() == hashedPassword);

            if (result != null)
            {
                return new DataResult<SeekerLoginDto>(ResultStatus.Success, new SeekerLoginDto
                {
                    Email = eMail,
                    FirstName = result.Result.FirstName,
                    LastName = result.Result.LastName,
                    Id = result.Result.Id,
                    Tc = result.Result.Tc,

                });
            }
            else
                return new DataResult<SeekerLoginDto>(ResultStatus.Error,Messages.Category.NotFound(isPlural:false),null);
            return null;
        }
        
        public async Task<IResult> CheckToMail(string eMail)
        {
          
            var result = await _seekerDal.AnyAsync(s => s.Email == eMail);
            if (result)
            {
                return new Result(ResultStatus.Success);
            }
            else
                return new Result(ResultStatus.Error);
        }

        public async Task<IResult> IsExists(string eMail, string Tc, string phone)
        {
           
            var result = await _seekerDal.AnyAsync(x => x.Email == eMail || x.Phone == phone || x.Tc == Tc);
            if (result)
            {
                return new Result(ResultStatus.Error, Messages.Category.Zatenmevcut());
            }
            else
            {
                return new Result(ResultStatus.Success);
            }

        }

        public async Task<IResult> RegisterForSeeker(SeekerRegisterDto seekerRegisterDto, string password)
        {
            
            var result = await _seekerDal.AnyAsync(x => x.Email == seekerRegisterDto.Email || x.Phone == seekerRegisterDto.Phone || x.Tc == seekerRegisterDto.TC);
            if (!result)
            {
                byte[] hasshedPassword = Encoding.ASCII.GetBytes(_extraMetot.DoMD5HashedString(password));
                var seeker = new Seeker()
                {
                    FirstName = seekerRegisterDto.FirstName,
                    LastName = seekerRegisterDto.LastName,
                    Tc = seekerRegisterDto.TC,
                    Phone = seekerRegisterDto.Phone,
                    Email = seekerRegisterDto.Email,
                    PasswordHash = hasshedPassword,
                };

                await _seekerDal.AddAsync(seeker);
                return new Result(ResultStatus.Success);

            }
            else
                return new Result(ResultStatus.Error, Messages.Category.Zatenmevcut());
        }
    }
}





//private readonly IUnitOfWork _unitOfWork;
//private readonly IConfiguration _configuration;
//private readonly IMapper _mapper;

//public AuthManager(IUnitOfWork unitOfWork, IConfiguration configuration, IMapper mapper)
//{
//    _unitOfWork = unitOfWork;
//    _configuration = configuration;
//    _mapper = mapper;
//}

//public  IDataResult<FinderLoginDto> LoginForFinder(FinderLoginDto fingerLoginDto)
//{
//    var finger =  _unitOfWork.Finders.GetByMailWithActive(fingerLoginDto.Email);
//    var result = _mapper.Map<FinderLoginDto>(finger);
//    if
//        (finger == null)
//    {
//        return new ErrorDataResult<FinderLoginDto>(result,Messages.MailNotFound);
//    }

//    if (result.IsBanned != false)
//    {
//        return new ErrorDataResult<FinderLoginDto>(result,Messages.BannedOrPassive);
//    }          

//    return new SuccessDataResult<FinderLoginDto>(result);

//}

//public IDataResult<SeekerLoginDto> LoginForFinder(SeekerLoginDto seekerLoginDto)
//{
//    throw new NotImplementedException();
//}

//public IDataResult<FinderRegisterDto> RegisterForFinder(FinderRegisterDto FinderRegisterDto)
//{
//    throw new NotImplementedException();
//}

//public IDataResult<SeekerRegisterDto> RegisterForFinder(SeekerRegisterDto seekerRegisterDto)
//{
//    throw new NotImplementedException();
//}

//public IResult UserExists(string email, string phone, string tc)
//{
//    throw new NotImplementedException();
//}