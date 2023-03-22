namespace DataAccess.Domain.Models;

public class DiscountTrade
{
    public decimal Id { get; set; }
    public int? BranchId { get; set; }
    public string? Name { get; set; }
    public decimal? FromValue { get; set; }
    public decimal? ToValue { get; set; }
    public int? CalcType { get; set; }
    public decimal? Perc { get; set; }
    public bool? IsAutomatic { get; set; }
    public bool? IsPeriod { get; set; }
    public bool? IsCash { get; set; }
    public bool? IsCredit { get; set; }
    public bool? IsCurr { get; set; }
    public DateTime? Dt1 { get; set; }
    public DateTime? Dt2 { get; set; }
    public string? Currency { get; set; }
    public string? Ship { get; set; }
    public Guid Rowguid { get; set; }
}
