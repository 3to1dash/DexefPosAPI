namespace DataAccess.Domain.Models;

public partial class SrvcItem
{
    public decimal Id { get; set; }
    public decimal? ParentId { get; set; }
    public string? Name { get; set; }
    public bool? Active { get; set; }
    public decimal? CostId { get; set; }
    public Guid Rowguid { get; set; }
}
