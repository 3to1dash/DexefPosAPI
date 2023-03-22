namespace DataAccess.Domain.Models;

public class SrvcRecieve
{
    public decimal Id { get; set; }
    public decimal? GroupId { get; set; }
    public DateTime? Dt { get; set; }
    public decimal? Num { get; set; }
    public string? Name { get; set; }
    public string? Phone1 { get; set; }
    public string? Phone2 { get; set; }
    public decimal? ItemId { get; set; }
    public string? Ship { get; set; }
    public string? Serial { get; set; }
    public string? Repair { get; set; }
    public DateTime? DueDt { get; set; }
    public decimal? Value { get; set; }
    public decimal? PayType { get; set; }
    public decimal? StorageId { get; set; }
    public decimal? AccountId { get; set; }
    public string? Note { get; set; }
    public string? WrittenBy { get; set; }
    public string? State { get; set; }
    public bool? Warranty { get; set; }
    public string? Barcode { get; set; }
    public decimal? Address { get; set; }
    public bool? Done { get; set; }
    public bool? Refused { get; set; }
    public bool? Waiting { get; set; }
    public decimal? ItemCost { get; set; }
    public decimal? Total { get; set; }
    public bool? IsValid { get; set; }
    public string? RepairedNote { get; set; }
    public string? RepairedBy { get; set; }
    public DateTime? RepairedDt { get; set; }
    public decimal? CostId { get; set; }
    public decimal? WorkRegNum { get; set; }
    public decimal? RegNum { get; set; }
    public decimal? Branchid { get; set; }
    public Guid Rowguid { get; set; }
}
