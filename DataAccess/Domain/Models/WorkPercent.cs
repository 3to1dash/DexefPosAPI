namespace DataAccess.Domain.Models;

public class WorkPercent
{
    public decimal Id { get; set; }
    public decimal? Workid { get; set; }
    public string? Levels { get; set; }
    public decimal? Fromval { get; set; }
    public decimal? Toval { get; set; }
    public decimal? Perc { get; set; }
    public Guid Rowguid { get; set; }
}