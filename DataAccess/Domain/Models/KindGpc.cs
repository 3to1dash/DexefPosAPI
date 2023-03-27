namespace DataAccess.Domain.Models;

public class KindGpc
{
    public string Id { get; set; } = null!;
    public string? ParentId { get; set; }
    public string? Code { get; set; }
    public string? ArName { get; set; }
    public string? ArNameDesc { get; set; }
    public string? EnName { get; set; }
    public string? EnnameDesc { get; set; }
    public bool? Active { get; set; }
    public bool? Isparent { get; set; }
    public Guid Rowguid { get; set; }
}