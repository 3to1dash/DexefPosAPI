namespace DataAccess.Domain.Models;

public class Dailyasset
{
    public decimal Id { get; set; }
    public decimal? Num { get; set; }
    public decimal? Assetid { get; set; }
    public string? Dealing { get; set; }
    public decimal? Credit { get; set; }
    public decimal? Debit { get; set; }
    public decimal? Balance { get; set; }
    public decimal? Regnum { get; set; }
    public DateTime? Dt { get; set; }
    public string? EngDealing { get; set; }
    public string? Deal { get; set; }
    public string? WrittenBy { get; set; }
    public string? Note { get; set; }
    public decimal? Destroyid { get; set; }
    public decimal? BranchId { get; set; }
    public decimal? Qty { get; set; }
    public decimal? RentId { get; set; }
    public Guid Rowguid { get; set; }
}
