namespace DataAccess.Domain.Models;

public class Currency
{
    public decimal Id { get; set; }
    public string? Num { get; set; }
    public string? Name { get; set; }
    public decimal? Value { get; set; }
    public bool? Active { get; set; }
    public string? LocalCurrency { get; set; }
    public decimal? PurchaseId { get; set; }
    public decimal? SaleId { get; set; }
    public string? Shortcut { get; set; }
    public bool? AutoUpdate { get; set; }
    public string? Transfer { get; set; }
    public bool? IsLocal { get; set; }
    public decimal? BuyRate { get; set; }
    public decimal? BuyOldVal { get; set; }
    public decimal? SaleRate { get; set; }
    public decimal? SaleOldVal { get; set; }
    public decimal? AvgPrice { get; set; }
    public bool? SubOne { get; set; }
    public Guid Rowguid { get; set; }
}
