namespace DataAccess.Domain.Models;

public class ArchiveRel
{
    public decimal Id { get; set; }
    public decimal? Rid { get; set; }
    public string? Caption { get; set; }
    public string? Detail { get; set; }
    public byte[]? Photo { get; set; }
    public Guid Rowguid { get; set; }
}