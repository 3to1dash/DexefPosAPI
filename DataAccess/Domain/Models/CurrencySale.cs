namespace DataAccess.Domain.Models;

public class CurrencySale
{
    public int Id { get; set; }
    public int? Branchid { get; set; }
    public DateTime? Dt { get; set; }
    public int? Num { get; set; }
    public int? CustId { get; set; }
    public string? Currency { get; set; }
    public byte? FromPaymentIndex { get; set; }
    public int? FromId { get; set; }
    public byte? ToPaymentIndex { get; set; }
    public int? ToId { get; set; }
    public string? MidCur { get; set; }
    public decimal? MidRate { get; set; }
    public decimal? TransferRate { get; set; }
    public decimal? Value { get; set; }
    public decimal? Price { get; set; }
    public decimal? Total { get; set; }
    public bool? IsMid { get; set; }
    public byte? IsDiv { get; set; }
    public decimal? Paid { get; set; }
    public decimal? Remain { get; set; }
    public decimal? RegNum { get; set; }
    public decimal? TaskId { get; set; }
    public string? WrittenBy { get; set; }
    public DateTime? LstUpdate { get; set; }
    public string? UpdatedBy { get; set; }
    public string? CustType { get; set; }
    public string? Note { get; set; }
    public decimal? UsedRate { get; set; }
    public Guid Rowguid { get; set; }
}
