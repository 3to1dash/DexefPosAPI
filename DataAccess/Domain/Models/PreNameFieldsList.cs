namespace DataAccess.Domain.Models;

public class PreNameFieldsList
{
    public decimal Id { get; set; }
    public string? Name { get; set; }
    public bool? IsDefault { get; set; }
    public Guid Rowguid { get; set; }
    public string? Type { get; set; }
    public int? TxtIndex { get; set; }
    public int? TypeId { get; set; }
}
