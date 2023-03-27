namespace DXPOS.DTOs;

public class ResultDto<T>
{
    public bool Success { get; set; }
    public ResultData<T> Data { get; set; }
    public List<Error> Errors { get; set; } = new();
}

public class ResultData<T>
{
    public bool IsAdded { get; set; }
    public bool IsUpdated { get; set; }
    public bool IsDeleted { get; set; }
    public bool IsSelected { get; set; }
    public T SubData { get; set; }
    public string Kind { get; set; }
}

public class Error
{
    public string Domain { get; set; }
    public List<ErrorMessage> Messages { get; set; } = new();
}

public class ErrorMessage
{
    public string Field { get; set; }
    public string Title { get; set; }
    public string Message { get; set; }
    public string Code { get; set; }
}