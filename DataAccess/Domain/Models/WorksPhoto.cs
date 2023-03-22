namespace DataAccess.Domain.Models;

/// <summary>
/// صور الموظفين
/// </summary>
public class WorksPhoto
{
    public decimal Id { get; set; }
    public int? WorkId { get; set; }
    public byte[]? Photo { get; set; }
    public Guid Rowguid { get; set; }
}
