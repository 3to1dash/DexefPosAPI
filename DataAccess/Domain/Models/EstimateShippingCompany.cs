namespace DataAccess.Domain.Models;

public class EstimateShippingCompany
{
    public int Id { get; set; }
    public string? Name { get; set; }
    public int? Num { get; set; }
    public string? Mob { get; set; }
    public string? Address { get; set; }
    public bool? Isactive { get; set; }
    public string? Note { get; set; }
}