namespace DataAccess.Domain.Models;

public partial class CostCenterEntry
{
    public int Id { get; set; }
    public int? CostCenter { get; set; }
    public int? SubCostCenter { get; set; }
    public decimal? Perc { get; set; }
    public string? CalcWay { get; set; }
    public Guid Rowguid { get; set; }
}
