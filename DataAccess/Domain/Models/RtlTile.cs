namespace DataAccess.Domain.Models;

public partial class RtlTile
{
    public decimal Id { get; set; }
    public string Ar { get; set; } = null!;
    public string? En { get; set; }
    public string? Fr { get; set; }
    public Guid Rowguid { get; set; }
}
