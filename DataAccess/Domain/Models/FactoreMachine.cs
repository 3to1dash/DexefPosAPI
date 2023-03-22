namespace DataAccess.Domain.Models;

public class FactoreMachine
{
    public decimal Id { get; set; }
    public decimal? Custid { get; set; }
    public decimal? Num { get; set; }
    public string? Name { get; set; }
    public string? Type { get; set; }
    public bool? Active { get; set; }
    public string? Note { get; set; }
    public Guid Rowguid { get; set; }
}
