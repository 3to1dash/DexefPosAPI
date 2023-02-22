namespace DataAccess.Domain.Models;

public partial class WorkItineraryEntry
{
    public decimal Id { get; set; }
    public bool? IsCust { get; set; }
    public decimal? CustId { get; set; }
    public string? Note { get; set; }
    public DateTime? FromTime { get; set; }
    public DateTime? ToTime { get; set; }
    public decimal? TaskId { get; set; }
    public decimal? OperatIndex { get; set; }
    public string? Ship { get; set; }
    public Guid Rowguid { get; set; }
}
