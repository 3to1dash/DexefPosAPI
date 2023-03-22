namespace DataAccess.Domain.Models;

public class Serial
{
    public long Id { get; set; }
    public int? ItemId { get; set; }
    public int? KindId { get; set; }
    public string? SerialNumber { get; set; }
    public string? CurrentState { get; set; }
    public Guid Rowguid { get; set; }
    public bool? Available { get; set; }
}
