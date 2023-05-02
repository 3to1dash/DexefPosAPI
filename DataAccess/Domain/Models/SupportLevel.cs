namespace DataAccess.Domain.Models;

public class SupportLevel
{
    public decimal Id { get; set; }
    public decimal? Num { get; set; }
    public string? Name { get; set; }
    public decimal? TypeId { get; set; }
    public Guid Rowguid { get; set; }
}