namespace DataAccess.Domain.Models;

public partial class CostCenterGroup
{
    public decimal Id { get; set; }
    public decimal? Num { get; set; }
    public string? Name { get; set; }
    public Guid Rowguid { get; set; }
}
