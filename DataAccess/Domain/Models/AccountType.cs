namespace DataAccess.Domain.Models;

public class AccountType
{
    public int Id { get; set; }
    public int? ParentId { get; set; }
    public int? ImageIndex { get; set; }
    public string? ArName { get; set; }
    public string? ArDesc { get; set; }
    public string? EnName { get; set; }
    public string? FrName { get; set; }
    public string? UrName { get; set; }
    public string? TuName { get; set; }
    public string? RoName { get; set; }
    public string? ChName { get; set; }
    public string? RuName { get; set; }
    public string? Endesc { get; set; }
    public string? FrDesc { get; set; }
    public string? UrDesc { get; set; }
    public string? TuDesc { get; set; }
    public string? RoDesc { get; set; }
    public string? ChDesc { get; set; }
    public string? RuDesc { get; set; }
    public Guid Rowguid { get; set; }
}