namespace DataAccess.Domain.Models;

public partial class DailyAssetExpense
{
    public int Id { get; set; }
    public bool? IsValue { get; set; }
    public bool? Taxable { get; set; }
    public decimal? TaxPerc { get; set; }
    public decimal? Tax { get; set; }
    public decimal? Amount { get; set; }
    public string? Currency { get; set; }
    public decimal? Rate { get; set; }
    public int? CustId { get; set; }
    public int? AccountId { get; set; }
    public decimal? Total { get; set; }
    public int? BillType { get; set; }
    public bool? IsCompanyExpense { get; set; }
    public string? Ship { get; set; }
    public Guid Rowguid { get; set; }
}
