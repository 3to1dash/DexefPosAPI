namespace DXPOS.DTOs;

public class ResultDto<T>
{
    public bool Success { get; set; }
    public ResultData<T>? Data { get; set; }
    public List<Error> Errors { get; set; } = new();
}

public class ResultData<T>
{
    public T? InnerData { get; set; }
    public string? Type { get; set; }
}

public class Error
{
    public string? Domain { get; set; }
    public List<ErrorMessage> Messages { get; set; } = new();
}

public class ErrorMessage
{
    public string? Title { get; set; }
    public string? Message { get; set; }
    public string? Code { get; set; }
}