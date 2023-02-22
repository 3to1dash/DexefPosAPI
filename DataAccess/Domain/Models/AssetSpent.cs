namespace DataAccess.Domain.Models;

public partial class AssetSpent
{
    public decimal Id { get; set; }
    public decimal? Num { get; set; }
    public DateTime? Dt { get; set; }
    public decimal? Assetid { get; set; }
    public decimal? ExpensId { get; set; }
    public decimal? CostId { get; set; }
    public decimal? SpentId { get; set; }
    public decimal? Value { get; set; }
    public string? Ship { get; set; }
    public int? PayType { get; set; }
    public decimal? AccountId { get; set; }
    public decimal? RegNum { get; set; }
    public decimal? Branchid { get; set; }
    public string? WrittenBy { get; set; }
    public string? Note { get; set; }
    public decimal? TaskId { get; set; }
    public string? Store { get; set; }
    public decimal? CustId { get; set; }
    public Guid Rowguid { get; set; }
}
