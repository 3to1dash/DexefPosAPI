namespace DataAccess.Domain.Models;

public class DailyCustAgingEntry
{
    public long Id { get; set; }
    public decimal? ParentTaskId { get; set; }
    public string? ParentDealing { get; set; }
    public string? Num { get; set; }
    public DateTime? Dt { get; set; }
    public decimal? TaskId { get; set; }
    public long? RegNum { get; set; }
    public string? Dealing { get; set; }
    public decimal? SourceValue { get; set; }
    public string? SourceCurrency { get; set; }
    public decimal? SourceRate { get; set; }
    public decimal? SourceAmount { get; set; }
    public string? SourcePaymentName { get; set; }
    public decimal? CustomerAmount { get; set; }
    public decimal? TargetValue { get; set; }
    public string? TargetCurrency { get; set; }
    public decimal? TargetTransferRate { get; set; }
    public decimal? TargetAmount { get; set; }
    public bool? IsDone { get; set; }
    public long? InstallmentId { get; set; }
    public Guid Rowguid { get; set; }
    public int? CustId { get; set; }
}
