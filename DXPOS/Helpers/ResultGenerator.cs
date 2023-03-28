using DXPOS.DTOs;

namespace DXPOS.Helpers;

public class ResultGenerator<T>
{
    private readonly bool _success;
    private readonly T _data;
    private readonly List<ErrorMessage> _errorMessages;

    public ResultGenerator(bool success, T data, List<ErrorMessage> errorMessages)
    {
        _success = success;
        _data = data;
        _errorMessages = errorMessages;
    }

    public ResultDto<T> Generate()
    {
        var Result = new ResultDto<T>
        {
            Success = _success,
            Data = new ResultData<T>()
            {
                InnerData = _data,
                Type = typeof(T).ToString(),
            },
            Errors = new List<Error>()
            {
                new() {Domain = "", Messages = _errorMessages}
            }
        };

        return Result;
    }
}