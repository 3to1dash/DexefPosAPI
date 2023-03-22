namespace DataAccess.Domain.Models;

public class Cycle
{
    public decimal Id { get; set; }
    public string? Name { get; set; }
    public bool? IsOn { get; set; }
    public int? TypeIndex { get; set; }
    public decimal? ValueLimit { get; set; }
    public Guid Rowguid { get; set; }
}
