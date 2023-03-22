namespace DataAccess.Domain.Models;

public class WorkSalaryPerc
{
    public decimal Id { get; set; }
    public string? Arb { get; set; }
    public string? Eng { get; set; }
    public string? Fre { get; set; }
    public string? Type { get; set; }
    public Guid Rowguid { get; set; }
}
