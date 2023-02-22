namespace DataAccess.Domain.Models;

public partial class FixedAssetBranchTransfer
{
    public int Id { get; set; }
    public DateTime? Dt { get; set; }
    public string? Dthijri { get; set; }
    public string? Dafter { get; set; }
    public int? Num { get; set; }
    public int? RegNum { get; set; }
    public decimal? TaskId { get; set; }
    public int BranchId { get; set; }
    public int? AccountId { get; set; }
    public int? OldAssetId { get; set; }
    public int? OldBranchId { get; set; }
    public int? OldCostId { get; set; }
    public string? OldAddress { get; set; }
    public string? OldNeighbour1 { get; set; }
    public string? OldNeighbour2 { get; set; }
    public string? OldNeighbour3 { get; set; }
    public string? OldStore { get; set; }
    public string? OldRoom { get; set; }
    public string? OldRackNum { get; set; }
    public decimal? OldQty { get; set; }
    public decimal? OldPrice { get; set; }
    public decimal? OldValue { get; set; }
    public decimal? OldTotal { get; set; }
    public int? NewAssetId { get; set; }
    public int? NewBranchId { get; set; }
    public int? NewCostId { get; set; }
    public string? NewAddress { get; set; }
    public string? NewNeighbour1 { get; set; }
    public string? NewNeighbour2 { get; set; }
    public string? NewNeighbour3 { get; set; }
    public string? NewStore { get; set; }
    public string? NewRoom { get; set; }
    public string? NewRackNum { get; set; }
    public decimal? NewQty { get; set; }
    public decimal? NewPrice { get; set; }
    public decimal? NewValue { get; set; }
    public decimal? NewTotal { get; set; }
    public string? WrittenBy { get; set; }
    public DateTime? LstUpdate { get; set; }
    public string? UpdatedBy { get; set; }
    public Guid Rowguid { get; set; }
    public bool? Attached { get; set; }
}
