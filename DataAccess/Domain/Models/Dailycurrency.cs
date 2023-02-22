namespace DataAccess.Domain.Models;

public partial class Dailycurrency
{
    public decimal Id { get; set; }
    public string? Name { get; set; }
    public string? Toname { get; set; }
    public DateTime? Dt { get; set; }
    public decimal? Val { get; set; }
    public decimal? Prevval { get; set; }
    public string? WrittenBy { get; set; }
    public string? Shortcut { get; set; }
    public decimal? BankPrice { get; set; }
    public decimal? PrevBankPrice { get; set; }
    public decimal? BestPrice { get; set; }
    public decimal? PrevBestPrice { get; set; }
    public decimal? TotalVal { get; set; }
    public Guid Rowguid { get; set; }
}
