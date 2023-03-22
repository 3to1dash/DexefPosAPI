namespace DataAccess.Domain.Models;

public class HrSalary
{
    public int Id { get; set; }
    public int? Num { get; set; }
    public string? ArName { get; set; }
    public bool? IsActive { get; set; }
    public bool? IsEquation { get; set; }
    public bool? IsAdd { get; set; }
    public int? Accountid { get; set; }
    public int? GroupId { get; set; }
    public bool? ShowInSalaries { get; set; }
    public string? Note { get; set; }
    public bool? IsIncrementPerc { get; set; }
    public decimal? IncrementPerc { get; set; }
    public bool? IsTax { get; set; }
    public decimal? MaximumTaxes { get; set; }
    public bool? IsInsurance { get; set; }
    public bool? IsMaximumValue { get; set; }
    public decimal? MaxValue { get; set; }
    public decimal? MinValue { get; set; }
    public string? EnName { get; set; }
    public string? FrName { get; set; }
    public string? UrName { get; set; }
    public string? TuName { get; set; }
    public string? RoName { get; set; }
    public string? ChName { get; set; }
    public string? RuName { get; set; }
    public string? Equation { get; set; }
    public bool? HasIfcondition { get; set; }
    public Guid Rowguid { get; set; }
}
