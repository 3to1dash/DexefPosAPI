namespace DataAccess.Domain.Models;

public class AccPayrollItem
{
    public int Id { get; set; }
    public int? ParentId { get; set; }
    public string? ResultType { get; set; }
    public string? Tags { get; set; }
    public string Type { get; set; } = null!;
    public string? ArName { get; set; }
    public string? CalcType { get; set; }
    public string? CalcGroup { get; set; }
    public string? EnName { get; set; }
    public string? FrName { get; set; }
    public string? UrName { get; set; }
    public string? TuName { get; set; }
    public string? RoName { get; set; }
    public string? ChName { get; set; }
    public string? RuName { get; set; }
    public Guid Rowguid { get; set; }
}