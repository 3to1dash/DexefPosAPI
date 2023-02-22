namespace DataAccess.Domain.Models;

public partial class GlIncome
{
    public decimal Id { get; set; }
    public string? Num { get; set; }
    public string? Name { get; set; }
    public string? Type { get; set; }
    public decimal? Debit { get; set; }
    public decimal? Credit { get; set; }
    public decimal? Debit1 { get; set; }
    public decimal? Credit1 { get; set; }
    public decimal? Balance1 { get; set; }
    public decimal? Balance2 { get; set; }
    public Guid Rowguid { get; set; }
}
