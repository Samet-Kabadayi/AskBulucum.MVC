using AutoMapper;
using Bulucum.DataAccess.Abstract;
using DataAccess.Context;
using Entities.DTOs.Finder;
using Services.Abstract;

namespace Services.Concreate
{
    public class FinderManager : IFinderService
    {
        private readonly IFinderDal _finderDal;
      

        public FinderManager(IFinderDal finderDal)
        {
            _finderDal = finderDal;            
        }
        //public async Task<IDataResult<FinderViewDto>> GetAllFindersNoneDeleted()
        //{
        //    var result = await _finderDal.GetAllAsync(x => x.IsActive == true && x.IsBanned == false);
        //    if (result !=null)
        //    {
        //        return new SuccessDataResult<List<FinderViewDto>>
        //    }
        //}
        public List<FinderViewDto> GetAllFindersNoneDeleted()
        {
            
            using (BulucumMVCContext context = new())
            {
                var fingers = from f in context.Finders
                               join c in context.Cities
                               on f.CityId equals c.Id
                               select new FinderViewDto
                               {
                                   FirstName = f.FirstName,
                                   Description = f.Description,
                                   SuccessfulWork = f.SuccessfulWork,
                                   Vote = f.Vote,
                                   City = c.Name,
                                 
                               };
                return fingers.ToList();                
            }
        }

    }
}
//var finders = await _finderDal.GetAllAsync(x => x.IsActive);
//var map = _mapper.Map<List<FinderViewDto>>(finders).ToList();

//if (map.Count>0)
//{
//    return new SuccessDataResult<map>();
//}
//else
//    return new ErrorDataResult<FinderViewDto>("Kullanıcı bulunamadı");