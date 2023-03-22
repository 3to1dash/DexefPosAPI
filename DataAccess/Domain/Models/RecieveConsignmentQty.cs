namespace DataAccess.Domain.Models;

public class RecieveConsignmentQty
{
    public int Id { get; set; }
    public int? BranchId { get; set; }
    public int? KindId { get; set; }
    public int? VendorId { get; set; }
    public decimal? InQty { get; set; }
    public decimal? OutQty { get; set; }
    public decimal? Qty { get; set; }
    public decimal? InCost { get; set; }
    public decimal? OutCost { get; set; }
    public decimal? Cost { get; set; }
    public Guid Rowguid { get; set; }
}
