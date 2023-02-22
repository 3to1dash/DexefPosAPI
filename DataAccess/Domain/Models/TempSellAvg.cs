namespace DataAccess.Domain.Models;

public partial class TempSellAvg
{
    public long? SellId { get; set; }
    public long? Itemid { get; set; }
    public DateTime? Dt { get; set; }
    public string? Trancode { get; set; }
    public decimal? Qty { get; set; }
    public decimal? Itemcost { get; set; }
    public decimal? TaskId { get; set; }
    public long? KindId { get; set; }
    public decimal? NewCost { get; set; }
    public Guid Rowguid { get; set; }
}
