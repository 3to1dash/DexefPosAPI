namespace DataAccess.Domain.Models;

public class Dailyuser
{
    public decimal Id { get; set; }
    public string? WrittenBy { get; set; }
    public decimal? Debit { get; set; }
    public decimal? Credit { get; set; }
    public decimal? Balance { get; set; }
    public string? Dealing { get; set; }
    public string? EngDealing { get; set; }
    public string? Deal { get; set; }
    public DateTime? Dt { get; set; }
    public decimal? Num { get; set; }
    public decimal? Custid { get; set; }
    public decimal? Regnum { get; set; }
    public decimal? Storageid { get; set; }
    public decimal? BranchId { get; set; }
    public Guid Rowguid { get; set; }
}
