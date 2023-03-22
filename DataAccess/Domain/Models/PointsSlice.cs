namespace DataAccess.Domain.Models;

public class PointsSlice
{
    public int Id { get; set; }
    public int? Num { get; set; }
    public string? Name { get; set; }
    public int? MinPoints { get; set; }
    public int? ReplacePoints { get; set; }
    public Guid Rowguid { get; set; }
}
