namespace DataAccess.Domain.Models;

public partial class SalaryItemType
{
    public int Id { get; set; }
    public string? Name { get; set; }
    public string? ItemType { get; set; }
    public string? CalcFor { get; set; }
    public int? CalcId { get; set; }
    public string? Speriod { get; set; }
    public int? Sdays { get; set; }
    public string? Note { get; set; }
    public Guid Rowguid { get; set; }
}
