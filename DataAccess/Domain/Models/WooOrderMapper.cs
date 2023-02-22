namespace DataAccess.Domain.Models;

public partial class WooOrderMapper
{
    public int Id { get; set; }
    public decimal TaskId { get; set; }
    public int RemoteId { get; set; }
    public string OnlineState { get; set; } = null!;
}
