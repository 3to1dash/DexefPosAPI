namespace DataAccess.Domain.Models;

public class FinalDayReport
{
    public decimal Id { get; set; }
    public string? BranchName { get; set; }
    public decimal? BranchId { get; set; }
    public decimal? SaleCount { get; set; }
    public decimal? SaleTotal { get; set; }
    public decimal? SaleDiscount { get; set; }
    public decimal? SaleExtra { get; set; }
    public decimal? SaleMoney { get; set; }
    public decimal? SaleRemain { get; set; }
    public decimal? PurchaseCount { get; set; }
    public decimal? PurchaseTotal { get; set; }
    public decimal? PurchaseDiscount { get; set; }
    public decimal? PurchaseExtra { get; set; }
    public decimal? PurchaseMoney { get; set; }
    public decimal? PurchaseRemain { get; set; }
    public decimal? RePurchaseCount { get; set; }
    public decimal? RePurchaseTotal { get; set; }
    public decimal? RePurchaseDiscount { get; set; }
    public decimal? RePurchaseExtra { get; set; }
    public decimal? RePurchaseMoney { get; set; }
    public decimal? RePurchaseRemain { get; set; }
    public decimal? ReSaleCount { get; set; }
    public decimal? ReSaleTotal { get; set; }
    public decimal? ReSaleDiscount { get; set; }
    public decimal? ReSaleExtra { get; set; }
    public decimal? ReSaleMoney { get; set; }
    public decimal? ReSaleRemain { get; set; }
    public decimal? ConvertCount { get; set; }
    public decimal? ConvertItems { get; set; }
    public decimal? ConvertTotal { get; set; }
    public decimal? ItemSendCount { get; set; }
    public decimal? ItemSendItems { get; set; }
    public decimal? ItemSendTotal { get; set; }
    public decimal? ItemRecievedCount { get; set; }
    public decimal? ItemRecievedItems { get; set; }
    public decimal? ItemRecievedTotal { get; set; }
    public decimal? PreItemCount { get; set; }
    public decimal? PreItemTotal { get; set; }
    public decimal? AfterItemCount { get; set; }
    public decimal? AfterItemTotal { get; set; }
    public decimal? PreCustTotal { get; set; }
    public decimal? AfterCustTotal { get; set; }
    public decimal? PreVendTotal { get; set; }
    public decimal? AfterVendTotal { get; set; }
    public decimal? PreStorageTotal { get; set; }
    public decimal? AfterStorageTotal { get; set; }
    public decimal? CashPaidCount { get; set; }
    public decimal? CashPaidTotal { get; set; }
    public decimal? CashRecievedCount { get; set; }
    public decimal? CashRecievedTotal { get; set; }
    public decimal? SpendCount { get; set; }
    public decimal? SpendTotal { get; set; }
    public decimal? InomeCount { get; set; }
    public decimal? InomeTotal { get; set; }
    public decimal? SaleOrderCount { get; set; }
    public decimal? SaleOrderTotal { get; set; }
    public decimal? SaleOrderDiscount { get; set; }
    public decimal? SaleOrderExtra { get; set; }
    public decimal? SaleOrderMoney { get; set; }
    public decimal? SaleOrderRemain { get; set; }
    public Guid Rowguid { get; set; }
}