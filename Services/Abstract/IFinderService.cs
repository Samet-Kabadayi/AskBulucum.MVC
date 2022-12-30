using Entities.DTOs.Finder;

namespace Services.Abstract
{
    public interface IFinderService
    {
        List<FinderViewDto> GetAllFindersNoneDeleted();
    }
}
