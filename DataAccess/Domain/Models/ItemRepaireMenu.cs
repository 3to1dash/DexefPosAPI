namespace DataAccess.Domain.Models;

public class ItemRepaireMenu
{
    public decimal Id { get; set; }
    public string? Name { get; set; }
    public decimal? Outvalue { get; set; }
    public decimal? Invalue { get; set; }
    public string? Note { get; set; }
    public string? WrittenBy { get; set; }
    public decimal? Period { get; set; }
    public bool? Hour { get; set; }
    public bool? Day { get; set; }
    public decimal? BranchId { get; set; }
    public string? ItemGroup { get; set; }
    public Guid Rowguid { get; set; }
}