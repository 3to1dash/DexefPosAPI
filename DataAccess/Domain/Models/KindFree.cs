namespace DataAccess.Domain.Models;

public class KindFree
{
    public decimal Id { get; set; }
    public int? Num { get; set; }
    public int? BranchId { get; set; }
    public int? StoreId { get; set; }
    public int? KindId { get; set; }
    public decimal? Qty { get; set; }
    public string? Unite { get; set; }
    public DateTime? Dt1 { get; set; }
    public DateTime? Dt2 { get; set; }
    public int? FreeKindId { get; set; }
    public string? FreeUnite { get; set; }
    public decimal? FreeQty { get; set; }
    public string? WrittenBy { get; set; }
    public Guid Rowguid { get; set; }
}