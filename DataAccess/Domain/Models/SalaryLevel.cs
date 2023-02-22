namespace DataAccess.Domain.Models;

public partial class SalaryLevel
{
    public int Id { get; set; }
    public int? SalaryId { get; set; }
    public int? RowId { get; set; }
    public int? PredefinedId { get; set; }
    public string? Condition { get; set; }
    public decimal? FromAmount { get; set; }
    public decimal? ToAmount { get; set; }
    public string? CalcType { get; set; }
    public decimal? CalcAmount { get; set; }
    public int? CalcSalaryId { get; set; }
    public decimal? CalcPerc { get; set; }
    public bool? AndThen { get; set; }
    public string? AlsoUse { get; set; }
    public string? AlsoCalcType { get; set; }
    public decimal? AlsoCalcAmount { get; set; }
    public int? AlsoCalcSalaryId { get; set; }
    public decimal? AlsoCalcPerc { get; set; }
    public Guid Rowguid { get; set; }
}
