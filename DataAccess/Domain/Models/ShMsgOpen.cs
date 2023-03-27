namespace DataAccess.Domain.Models;

public class ShMsgOpen
{
    public decimal Id { get; set; }
    public decimal? Num { get; set; }
    public DateTime? Dt { get; set; }
    public string? Name { get; set; }
    public string? Item { get; set; }
    public decimal? CustId { get; set; }
    public decimal? Box { get; set; }
    public decimal? Qty { get; set; }
    public decimal? Price { get; set; }
    public decimal? Total { get; set; }
    public string? Note { get; set; }
    public string? WrittenBy { get; set; }
    public bool? Active { get; set; }
    public bool? IsPartner { get; set; }
    public bool? IsBill { get; set; }
    public bool? IsVendor { get; set; }
    public decimal? RegNum { get; set; }
    public bool? IsBox { get; set; }
    public decimal? BranchId { get; set; }
    public Guid Rowguid { get; set; }
}