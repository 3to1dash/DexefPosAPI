namespace DataAccess.Domain.Models;

public class TempFinalDatum
{
    public long? Id { get; set; }
    public long? KindId { get; set; }
    public long? ItemId { get; set; }
    public decimal? NewCost { get; set; }
    public Guid Rowguid { get; set; }
}
