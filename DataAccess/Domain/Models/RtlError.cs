namespace DataAccess.Domain.Models;

public class RtlError
{
    public decimal Id { get; set; }
    public string Num { get; set; } = null!;
    public string Ar { get; set; } = null!;
    public string? En { get; set; }
    public string? Fr { get; set; }
    public Guid Rowguid { get; set; }
}
