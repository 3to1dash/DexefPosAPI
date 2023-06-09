namespace DataAccess.Domain.Models;

public class ShMsgSale
{
    public decimal Id { get; set; }
    public decimal? Num { get; set; }
    public DateTime? Dt { get; set; }
    public decimal? MsgId { get; set; }
    public decimal? CustId { get; set; }
    public decimal? BranchId { get; set; }
    public decimal? VendorId { get; set; }
    public decimal? WorkId { get; set; }
    public decimal? StorageId { get; set; }
    public decimal? IncomeId { get; set; }
    public decimal? Price { get; set; }
    public decimal? Qty { get; set; }
    public decimal? Box { get; set; }
    public decimal? BoxRent { get; set; }
    public decimal? ReBox { get; set; }
    public decimal? ReBoxRent { get; set; }
    public decimal? BoxSum { get; set; }
    public decimal? Root { get; set; }
    public decimal? RootTotal { get; set; }
    public decimal? RentPrice { get; set; }
    public decimal? RentValue { get; set; }
    public decimal? Paid { get; set; }
    public decimal? BillTotal { get; set; }
    public decimal? BoxTotal { get; set; }
    public decimal? BoxRentTotal { get; set; }
    public bool? IsBox { get; set; }
    public decimal? Total { get; set; }
    public decimal? TotalBillBox { get; set; }
    public decimal? RemainBox { get; set; }
    public decimal? RemainBoxRent { get; set; }
    public decimal? Remain { get; set; }
    public decimal? RegNum { get; set; }
    public string? WrittenBy { get; set; }
    public string? Note { get; set; }
    public string? Ship { get; set; }
    public decimal? BranchBoxId { get; set; }
    public decimal? CustBoxId { get; set; }
    public DateTime? ShipDue { get; set; }
    public bool? IsPaid { get; set; }
    public bool? IsBoxed { get; set; }
    public decimal? PaidValue { get; set; }
    public string? MsgName { get; set; }
    public decimal? TermId { get; set; }
    public decimal? BoxRegNum { get; set; }
    public decimal? RentId { get; set; }
    public decimal? VendorValue { get; set; }
    public decimal? VendorRemain { get; set; }
    public decimal? VendorTotal { get; set; }
    public decimal? Perc { get; set; }
    public decimal? PercValue { get; set; }
    public bool? MsgIsBox { get; set; }
    public string? Dealing { get; set; }
    public decimal? StorageRentId { get; set; }
    public decimal? PercId { get; set; }
    public Guid Rowguid { get; set; }
}