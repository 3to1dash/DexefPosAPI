namespace DataAccess.Domain.Models;

public class ShippingDriver
{
    public int Id { get; set; }
    public int? BranchId { get; set; }
    public int? Num { get; set; }
    public string? ArName { get; set; }
    public string? EnName { get; set; }
    public string? FrName { get; set; }
    public string? UrName { get; set; }
    public string? TuName { get; set; }
    public string? RoName { get; set; }
    public string? ChName { get; set; }
    public string? RuName { get; set; }
    public int? CarId { get; set; }
    public string? Mob1 { get; set; }
    public string? Mob2 { get; set; }
    public string? Mob3 { get; set; }
    public string? LicenseNum { get; set; }
    public string? LicenseType { get; set; }
    public string? Note { get; set; }
    public bool? Active { get; set; }
    public Guid Rowguid { get; set; }
}