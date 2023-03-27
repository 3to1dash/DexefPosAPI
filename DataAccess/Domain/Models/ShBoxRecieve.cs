namespace DataAccess.Domain.Models;

public class ShBoxRecieve
{
    public decimal Id { get; set; }
    public decimal? Num { get; set; }
    public DateTime? Dt { get; set; }
    public string? Dealing { get; set; }
    public decimal? RegNum { get; set; }
    public decimal? BranchId { get; set; }
    public decimal? CustId { get; set; }
    public decimal? MsgId { get; set; }
    public decimal? Qty { get; set; }
    public decimal? Box { get; set; }
    public decimal? BoxRent { get; set; }
    public decimal? ReBox { get; set; }
    public decimal? ReBoxRent { get; set; }
    public bool? IsMsg { get; set; }
    public decimal? SaleRegNum { get; set; }
    public Guid Rowguid { get; set; }
}