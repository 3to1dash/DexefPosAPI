namespace DataAccess.Domain.Models;

public class Patient
{
    public int Id { get; set; }
    public int? Num { get; set; }
    public string? Name { get; set; }
    public int? InsuranceCompanyId { get; set; }
    public int? PercentId { get; set; }
    public string? Mob1 { get; set; }
    public string? Mob2 { get; set; }
    public string? Mob3 { get; set; }
    public string? Mail { get; set; }
    public string? Address { get; set; }
}
