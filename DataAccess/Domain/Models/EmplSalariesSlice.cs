namespace DataAccess.Domain.Models;

public class EmplSalariesSlice
{
    public int Id { get; set; }
    public string? ArName { get; set; }
    public string? EnName { get; set; }
    public string? FrName { get; set; }
    public string? UrName { get; set; }
    public string? TuName { get; set; }
    public string? RoName { get; set; }
    public string? ChName { get; set; }
    public string? RuName { get; set; }
    public string? Writtenby { get; set; }
    public DateTime? Dt { get; set; }
    public bool? Active { get; set; }
    public DateTime? LstUpdate { get; set; }
    public string? UpdatedBy { get; set; }
    public string? ItemType { get; set; }
    public bool? IsfixedAmount { get; set; }
    public string? CalcPeriod { get; set; }
    public bool? CanEdit { get; set; }
}