namespace DataAccess.Domain.Models;

public class AttendanceLog
{
    public decimal Id { get; set; }
    public decimal? Num { get; set; }
    public string? Dt { get; set; }
    public string? State { get; set; }
    public Guid Rowguid { get; set; }
}