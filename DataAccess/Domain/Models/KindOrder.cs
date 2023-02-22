namespace DataAccess.Domain.Models;

public partial class KindOrder
{
    public decimal Id { get; set; }
    public decimal? Kindid { get; set; }
    public decimal? ItemId { get; set; }
    public decimal? Qty { get; set; }
    public decimal? Branchid { get; set; }
    public decimal? PeriodId { get; set; }
    public decimal? Cpu { get; set; }
    public bool? Done { get; set; }
    public Guid Rowguid { get; set; }
}
