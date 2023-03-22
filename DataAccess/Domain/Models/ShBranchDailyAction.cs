namespace DataAccess.Domain.Models;

public class ShBranchDailyAction
{
    public decimal Id { get; set; }
    public decimal? BranchId { get; set; }
    public decimal? Sales { get; set; }
    public decimal? Recieve { get; set; }
    public decimal? Paid { get; set; }
    public decimal? Spent { get; set; }
    public decimal? Rent { get; set; }
    public decimal? MsgSpent { get; set; }
    public string? Ship { get; set; }
    public decimal? Vendor { get; set; }
    public decimal? Cust { get; set; }
    public decimal? BoxIn { get; set; }
    public decimal? BoxOut { get; set; }
    public Guid Rowguid { get; set; }
}
