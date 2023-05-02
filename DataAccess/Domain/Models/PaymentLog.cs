namespace DataAccess.Domain.Models;

public class PaymentLog
{
    public long Id { get; set; }
    public string? Dealing { get; set; }
    public DateTime? Dt { get; set; }
    public decimal? TaskId { get; set; }
    public decimal? Debit { get; set; }
    public decimal? Credit { get; set; }
    public decimal? TargetTaskId { get; set; }
    public string? TargetDealing { get; set; }
    public string? TargetNum { get; set; }
    public decimal? TargetDebit { get; set; }
    public decimal? TargetCredit { get; set; }
    public string? TargetCurrency { get; set; }
    public decimal? TargetTransferRate { get; set; }
}