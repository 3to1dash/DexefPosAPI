using DXPOS.DTOs;

namespace DXPOS.Helpers;

public class ResultGenerator<T>
{
    private readonly bool _success;
    private readonly T _data;
    private readonly ErrorMessage _errorMessages;

    public ResultGenerator(bool success, T data, ErrorMessage errorMessage)
    {
        _success = success;
        _data = data;
        _errorMessages = errorMessage;
    }

    public ResultDto<T> Generate()
    {
        var Result = new ResultDto<T>
        {
            Success = _success,
            Data = _data,
            ErrorMessage = _errorMessages
        };

        return Result;
    }
}