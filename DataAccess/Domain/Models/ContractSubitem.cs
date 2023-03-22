namespace DataAccess.Domain.Models;

public class ContractSubitem
{
    public decimal? Num { get; set; }
    public string? Name { get; set; }
    public string? Item { get; set; }
    public string? Detail { get; set; }
    public decimal? Value { get; set; }
    public bool? Active { get; set; }
    public Guid Rowguid { get; set; }
}
