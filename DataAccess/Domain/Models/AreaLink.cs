namespace DataAccess.Domain.Models;

public partial class AreaLink
{
    public int Id { get; set; }
    public int? AreaId { get; set; }
    public string? AreaType { get; set; }
    public string? Ship { get; set; }
    public int? RepId { get; set; }
    public Guid Rowguid { get; set; }
}
