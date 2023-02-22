namespace DataAccess.Domain.Models;

public partial class CustDealing
{
    public long Id { get; set; }
    public int? Branchid { get; set; }
    public DateTime? Dt { get; set; }
    public long? Num { get; set; }
    public int? Custid { get; set; }
    public string? Ship { get; set; }
    public string? Currency { get; set; }
    public decimal? Rate { get; set; }
    public decimal? Value { get; set; }
    public decimal? Total { get; set; }
    public bool? Iscredit { get; set; }
    public decimal? RegNum { get; set; }
    public decimal? TaskId { get; set; }
    public string? Note { get; set; }
    public string? Dealing { get; set; }
    public int? CapitalId { get; set; }
    public int? MyIndex { get; set; }
    public string? WrittenBy { get; set; }
    public DateTime? LstUpdate { get; set; }
    public string? UpdatedBy { get; set; }
    public string? CustType { get; set; }
    public Guid Rowguid { get; set; }
    public string? Dafter { get; set; }
    public string? BillNum { get; set; }
    public decimal? Amount { get; set; }
    public decimal? Taxes { get; set; }
    public int? TaxId { get; set; }
    public decimal? TaxPerc { get; set; }
    public bool? Taxable { get; set; }
}
