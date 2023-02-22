namespace DataAccess.Domain.Models;

public partial class WTempattendance
{
    public decimal Id { get; set; }
    public decimal? Num { get; set; }
    public string? Name { get; set; }
    public string? Period { get; set; }
    public DateTime? Dt { get; set; }
    public DateTime? Time { get; set; }
    public decimal? Idnum { get; set; }
    public decimal? Value { get; set; }
    public Guid Rowguid { get; set; }
}
