
using Core.Results.Abstract;

namespace Services.Abstract
{
    public interface ISeekerService
    {
        Task<IResult> ChangeConfirmPerson(string Tc);
    }
}
