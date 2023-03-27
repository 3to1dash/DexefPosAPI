namespace DataAccess.Domain.Models;

public class KindQoutum
{
    public int Id { get; set; }
    public int? BranchId { get; set; }
    public string? Ship { get; set; }
    public bool? Isall { get; set; }
    public DateTime? FromDt { get; set; }
    public DateTime? ToDt { get; set; }
    public bool? Active { get; set; }
    public int? ItemCount { get; set; }
    public Guid Rowguid { get; set; }
}