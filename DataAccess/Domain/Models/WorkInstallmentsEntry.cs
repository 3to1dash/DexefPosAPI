namespace DataAccess.Domain.Models;

public class WorkInstallmentsEntry
{
    public decimal Id { get; set; }
    public decimal? Workid { get; set; }
    public DateTime? Dt { get; set; }
    public decimal? Value { get; set; }
    public decimal? Paid { get; set; }
    public decimal? Remain { get; set; }
    public bool? Done { get; set; }
    public string? Note { get; set; }
    public decimal? TaskId { get; set; }
    public bool? Closed { get; set; }
    public DateTime? PaidDt { get; set; }
    public decimal? PaidTaskId { get; set; }
    public Guid Rowguid { get; set; }
}
