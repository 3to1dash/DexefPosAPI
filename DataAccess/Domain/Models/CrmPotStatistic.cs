namespace DataAccess.Domain.Models;

public class CrmPotStatistic
{
    public decimal Id { get; set; }
    public decimal? ParentId { get; set; }
    public decimal? Num { get; set; }
    public string? Name { get; set; }
    public string? Description { get; set; }
    public decimal? Type { get; set; }
    public Guid Rowguid { get; set; }
}
