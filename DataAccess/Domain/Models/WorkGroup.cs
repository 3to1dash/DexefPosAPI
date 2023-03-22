namespace DataAccess.Domain.Models;

public class WorkGroup
{
    public decimal Id { get; set; }
    public decimal? Num { get; set; }
    public string? Name { get; set; }
    public decimal? Subid { get; set; }
    public string? Adress { get; set; }
    public bool? Active { get; set; }
    public Guid Rowguid { get; set; }
}
