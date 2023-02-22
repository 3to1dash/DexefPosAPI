namespace DataAccess.Domain.Models;

public partial class HrSetting
{
    public int Id { get; set; }
    public int? ParentId { get; set; }
    public int? VisibleIndex { get; set; }
    public string? IndexType { get; set; }
    public string? ColName { get; set; }
    public string? LinkedTable { get; set; }
    public string? ArName { get; set; }
    public string? ArNameDesc { get; set; }
    public string? EnName { get; set; }
    public string? FrName { get; set; }
    public string? UrName { get; set; }
    public string? TuName { get; set; }
    public string? RoName { get; set; }
    public string? ChName { get; set; }
    public string? RuName { get; set; }
    public string? EnNameDesc { get; set; }
    public string? FrNameDesc { get; set; }
    public string? UrNameDesc { get; set; }
    public string? TuNameDesc { get; set; }
    public string? RoNameDesc { get; set; }
    public string? ChNameDesc { get; set; }
    public string? RuNameDesc { get; set; }
}
