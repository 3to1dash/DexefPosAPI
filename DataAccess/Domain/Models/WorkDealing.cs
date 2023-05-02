namespace DataAccess.Domain.Models;

public class WorkDealing
{
    public decimal? Num { get; set; }
    public string? Name { get; set; }
    public string? Dealing { get; set; }
    public decimal? Hour { get; set; }
    public decimal? Solfa { get; set; }
    public decimal? Khasm { get; set; }
    public Guid Rowguid { get; set; }
}