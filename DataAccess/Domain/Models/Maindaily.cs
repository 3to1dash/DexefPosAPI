namespace DataAccess.Domain.Models;

public partial class Maindaily
{
    public string? Dafter { get; set; }
    public decimal? Num { get; set; }
    public string? Dealing { get; set; }
    public DateTime? Dt { get; set; }
    public string? Fromaccount { get; set; }
    public decimal? Fromnum { get; set; }
    public string? Toaccount { get; set; }
    public decimal? Tonum { get; set; }
    public decimal? Credit { get; set; }
    public decimal? Debit { get; set; }
    public Guid Rowguid { get; set; }
}
