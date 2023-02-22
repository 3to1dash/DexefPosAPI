namespace DataAccess.Domain.Models;

public partial class DailyMaintenance
{
    public int Id { get; set; }
    public DateTime? Dt { get; set; }
    public int? BranchId { get; set; }
    public string? Dealing { get; set; }
    public int? MaintenanceId { get; set; }
    public decimal? Debit { get; set; }
    public decimal? Credit { get; set; }
    public decimal? Value { get; set; }
    public decimal? ActualRate { get; set; }
    public decimal? LocalDebit { get; set; }
    public decimal? LocalCredit { get; set; }
    public string? Currency { get; set; }
    public decimal? Rate { get; set; }
    public string? Status { get; set; }
    public int? CustId { get; set; }
    public int? TecId { get; set; }
    public string? WrittenBy { get; set; }
    public int? RegNum { get; set; }
    public decimal? TaskId { get; set; }
    public int? Cpu { get; set; }
    public bool? Deleted { get; set; }
    public string? DeletedBy { get; set; }
    public bool? Updated { get; set; }
}
