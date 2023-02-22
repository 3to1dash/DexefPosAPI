namespace DataAccess.Domain.Models;

public partial class ContractSub
{
    public decimal? Num { get; set; }
    public string? Name { get; set; }
    public decimal? Renum { get; set; }
    public string? Main { get; set; }
    public string? Advisore { get; set; }
    public string? Adress { get; set; }
    public decimal? Total { get; set; }
    public decimal? Intercepts { get; set; }
    public decimal? Ensure { get; set; }
    public decimal? Reensurestart { get; set; }
    public decimal? Reensureend { get; set; }
    public decimal? Money { get; set; }
    public decimal? Spent { get; set; }
    public DateTime? Dt { get; set; }
    public DateTime? Dtstart { get; set; }
    public DateTime? Dtend { get; set; }
    public DateTime? Dtexp { get; set; }
    public bool? Active { get; set; }
    public Guid Rowguid { get; set; }
}
