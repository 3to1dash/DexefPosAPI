namespace DataAccess.Domain.Models;

public class TempPurchase
{
    public long Id { get; set; }
    public long? Itemid { get; set; }
    public DateTime? Dt { get; set; }
    public string? Trancode { get; set; }
    public decimal? OrgQty { get; set; }
    public decimal? AvailableQty { get; set; }
    public decimal? OrgCost { get; set; }
    public decimal? Itemcost { get; set; }
    public decimal? TaskId { get; set; }
    public long? KindId { get; set; }
    public string? Dealing { get; set; }
    public decimal? UpdatedCost { get; set; }
}
