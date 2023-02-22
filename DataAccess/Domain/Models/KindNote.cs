namespace DataAccess.Domain.Models;

public partial class KindNote
{
    public decimal Id { get; set; }
    public string? Dealing { get; set; }
    public decimal? Num { get; set; }
    public DateTime? Dt { get; set; }
    public int? StoreId { get; set; }
    public long? KindId { get; set; }
    public long? ItemId { get; set; }
    public string? Note { get; set; }
    public bool? Active { get; set; }
    public Guid Rowguid { get; set; }
}
