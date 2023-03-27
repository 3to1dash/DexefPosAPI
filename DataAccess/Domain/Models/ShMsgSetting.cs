namespace DataAccess.Domain.Models;

public class ShMsgSetting
{
    public decimal Id { get; set; }
    public decimal? MsgId { get; set; }
    public bool? Distribute { get; set; }
    public bool? Paid { get; set; }
    public bool? Reiceved { get; set; }
    public bool? Done { get; set; }
    public bool? IsSold { get; set; }
    public decimal? BoxIn { get; set; }
    public decimal? QtyIn { get; set; }
    public decimal? BoxBranch { get; set; }
    public decimal? QtyBranch { get; set; }
    public decimal? BoxSold { get; set; }
    public decimal? QtySold { get; set; }
    public decimal? BoxReturned { get; set; }
    public decimal? MoneyVendor { get; set; }
    public decimal? MoneyRecieved { get; set; }
    public decimal? MoneySold { get; set; }
    public decimal? MoneyRoot { get; set; }
    public decimal? Spent { get; set; }
    public decimal? SpentPaid { get; set; }
    public decimal? RemainBox { get; set; }
    public decimal? Remain { get; set; }
    public decimal? RemainVendor { get; set; }
    public decimal? VendorPaid { get; set; }
    public decimal? PercVal { get; set; }
    public decimal? BranchId { get; set; }
    public decimal? VendorId { get; set; }
    public Guid Rowguid { get; set; }
}