namespace DataAccess.Domain.Models;

public class BillHistory
{
    public decimal Id { get; set; }
    public DateTime? Dt { get; set; }
    public string? TransactionType { get; set; }
    public string? WrittenBy { get; set; }
    public string? Dealing { get; set; }
    public decimal? TaskId { get; set; }
    public int? RegNum { get; set; }
    public string? BillNum { get; set; }
    public int? ItemCount { get; set; }
    public decimal? NetTotal { get; set; }
    public int? CustId { get; set; }
    public string? Memo { get; set; }
    public decimal? TargetTaskId { get; set; }
    public string? TargetDealing { get; set; }
    public string? TargetBillNum { get; set; }
    public Guid Rowguid { get; set; }
}