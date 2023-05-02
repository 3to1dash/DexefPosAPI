namespace DataAccess.Domain.Models;

public class ShDailyMsg
{
    public decimal Id { get; set; }
    public decimal? Num { get; set; }
    public DateTime? Dt { get; set; }
    public string? Dealing { get; set; }
    public decimal? MsgId { get; set; }
    public decimal? InQty { get; set; }
    public decimal? InBox { get; set; }
    public decimal? Inprice { get; set; }
    public decimal? InTotal { get; set; }
    public decimal? OutQty { get; set; }
    public decimal? OutBox { get; set; }
    public decimal? OutPrice { get; set; }
    public decimal? Root { get; set; }
    public decimal? Perc { get; set; }
    public decimal? OutTotal { get; set; }
    public decimal? OutVendor { get; set; }
    public decimal? BranchId { get; set; }
    public decimal? Custid { get; set; }
    public Guid Rowguid { get; set; }
}