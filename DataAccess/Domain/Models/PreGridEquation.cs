namespace DataAccess.Domain.Models;

public class PreGridEquation
{
    public int Id { get; set; }
    public string? Name { get; set; }
    public string? Value { get; set; }
    public string? Equation { get; set; }
    public bool? CanEdit { get; set; }
    public Guid Rowguid { get; set; }
}