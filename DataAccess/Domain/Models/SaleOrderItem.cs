namespace DataAccess.Domain.Models;

public class SaleOrderItem
{
    public decimal Id { get; set; }
    public decimal? OrderId { get; set; }
    public decimal? BranchId { get; set; }
    public decimal? Cpu { get; set; }
    public decimal? DayIndex { get; set; }
    public decimal? PeriodId { get; set; }
    public DateTime? Dt { get; set; }
    public decimal? Num { get; set; }
    public decimal? KindId { get; set; }
    public decimal? Qty { get; set; }
    public string? Unite { get; set; }
    public decimal? Price { get; set; }
    public decimal? CustId { get; set; }
    public decimal? Total { get; set; }
    public DateTime? DtDue { get; set; }
    public bool? Isdone { get; set; }
    public bool? InProgress { get; set; }
    public Guid Rowguid { get; set; }
}
