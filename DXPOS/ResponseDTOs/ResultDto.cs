namespace DXPOS.ResponseDTOs;

public class ResultDto<T>
{
    public bool Success { get; set; }
    public T Data { get; set; }
    public ErrorMessage ErrorMessage { get; set; }
}

public class ErrorMessage
{
    public string? Title { get; set; }
    public string? Message { get; set; }
    public string? Code { get; set; }
}