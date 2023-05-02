namespace DataAccess.Domain.Models;

public class WooKindMapper
{
    public long Id { get; set; }
    public long LocalId { get; set; }
    public long RemoteId { get; set; }
    public string RemoteState { get; set; } = null!;
    public bool IsOnline { get; set; }
    public bool IsUpdated { get; set; }
    public int? NoOfImages { get; set; }
    public int? StoreKindId { get; set; }
}