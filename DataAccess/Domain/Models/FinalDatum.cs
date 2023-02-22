namespace DataAccess.Domain.Models;

public partial class FinalDatum
{
    public long? KindId { get; set; }
    public decimal? TaskId { get; set; }
    public long? Itemid { get; set; }
    public long? SellId { get; set; }
    public DateTime? SellDate { get; set; }
    public decimal? SellQty { get; set; }
    public decimal? NewCost { get; set; }
}
