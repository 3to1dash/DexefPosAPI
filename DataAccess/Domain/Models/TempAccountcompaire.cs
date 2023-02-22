namespace DataAccess.Domain.Models;

public partial class TempAccountcompaire
{
    public decimal Id { get; set; }
    public string? Name { get; set; }
    public decimal? Num { get; set; }
    public string? Parent { get; set; }
    public bool? Isparent { get; set; }
    public string? Type { get; set; }
    public decimal? Debit1 { get; set; }
    public decimal? Debit2 { get; set; }
    public decimal? Credit1 { get; set; }
    public decimal? Credit2 { get; set; }
    public decimal? Balance1 { get; set; }
    public decimal? Balance2 { get; set; }
    public Guid Rowguid { get; set; }
}
