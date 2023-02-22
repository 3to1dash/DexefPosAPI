namespace DataAccess.Domain.Models;

public partial class SadadService
{
    public decimal Id { get; set; }
    public DateTime? Dt { get; set; }
    public decimal? Num { get; set; }
    public decimal? BranchId { get; set; }
    public decimal? TaskId { get; set; }
    public decimal? RegNum { get; set; }
    public decimal? CustId { get; set; }
    public decimal? AccountId { get; set; }
    public decimal? PayType { get; set; }
    public decimal? ToAccount { get; set; }
    public decimal? Total { get; set; }
    public string? Ship { get; set; }
    public string? WrittenBy { get; set; }
    public string? Note { get; set; }
    public decimal? ItemCounts { get; set; }
    public string? Currency { get; set; }
    public decimal? Rate { get; set; }
    public decimal? ItemTotal { get; set; }
    public decimal? CostId { get; set; }
    public string? Dafter { get; set; }
    public Guid Rowguid { get; set; }
}
