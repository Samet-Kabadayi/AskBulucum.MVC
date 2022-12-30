using Core.Entities.Concreate;
using Core.Results.ComplexTypes;

namespace Core.Results.Abstract
{
    public interface IResult
    {
        public ResultStatus ResultStatus { get;} // ResultStatus.Success // ResultStatus.Error
        public string Message { get;}
        public Exception Exception { get;}
        public IEnumerable<ValidationError> ValidationErrors { get; set; } // ValidationErrors.Add
    }
}
