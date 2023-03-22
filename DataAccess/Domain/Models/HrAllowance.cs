namespace DataAccess.Domain.Models;

public class HrAllowance
{
    public decimal Id { get; set; }
    public decimal? Num { get; set; }
    public string? ArName { get; set; }
    public bool? Active { get; set; }
    public decimal? Amount { get; set; }
    public decimal? PercCo { get; set; }
    public decimal? PercWork { get; set; }
    public bool? HasMax { get; set; }
    public decimal? MaxAmount { get; set; }
    public int? AccountIdco { get; set; }
    public int? AccountIdwork { get; set; }
    public int? CostId { get; set; }
    public bool? HasIf { get; set; }
    public string? EnName { get; set; }
    public string? FrName { get; set; }
    public string? UrName { get; set; }
    public string? TuName { get; set; }
    public string? RoName { get; set; }
    public string? ChName { get; set; }
    public string? RuName { get; set; }
    public int? RepeatPerYear { get; set; }
    public int? MinRepeat { get; set; }
    public bool? IsWork { get; set; }
    public bool? IsEdit { get; set; }
    public Guid Rowguid { get; set; }
}
