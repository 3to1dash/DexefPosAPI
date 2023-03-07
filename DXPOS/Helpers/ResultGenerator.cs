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

    public ResultDto<T> AddingMethods()
    {
        var Result = new ResultDto<T>
        {
            Success = _success,
            Data = new ResultData<T>()
            {
                IsAdded = true,
                IsDeleted = false,
                IsSelected = false,
                IsUpdated = false,
                SubData = _data,
                Kind = typeof(T).ToString(),
            },
            Errors = new List<Error>()
            {
                new Error() { Domain = "", Messages = _errorMessages}
            }
        };

        return Result;
    }

    public ResultDto<T> DeletingMethods()
    {
        var Result = new ResultDto<T>
        {
            Success = _success,
            Data = new ResultData<T>()
            {
                IsAdded = false,
                IsDeleted = true,
                IsSelected = false,
                IsUpdated = false,
                SubData = _data,
                Kind = typeof(T).ToString(),
            },
            Errors = new List<Error>()
            {
                new Error() { Domain = "", Messages = _errorMessages}
            }
        };

        return Result;
    }
    public ResultDto<T> UpdatingMethods()
    {
        var Result = new ResultDto<T>
        {
            Success = _success,
            Data = new ResultData<T>()
            {
                IsAdded = false,
                IsDeleted = false,
                IsSelected = false,
                IsUpdated = true,
                SubData = _data,
                Kind = typeof(T).ToString(),
            },
            Errors = new List<Error>()
            {
                new Error() { Domain = "", Messages = _errorMessages}
            }
        };

        return Result;
    }
    public ResultDto<T> SelectingMethods()
    {
        var Result = new ResultDto<T>
        {
            Success = _success,
            Data = new ResultData<T>()
            {
                IsAdded = false,
                IsDeleted = false,
                IsSelected = true,
                IsUpdated = false,
                SubData = _data,
                Kind = typeof(T).ToString(),
            },
            Errors = new List<Error>()
            {
                new Error() { Domain = "", Messages = _errorMessages}
            }
        };

        return Result;
    }
}
