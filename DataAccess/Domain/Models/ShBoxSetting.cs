namespace DataAccess.Domain.Models;

public class ShBoxSetting
{
    public decimal Id { get; set; }
    public decimal? Buy { get; set; }
    public decimal? Sale { get; set; }
    public decimal? Rent { get; set; }
    public decimal? StorageId { get; set; }
    public decimal? StorageRentId { get; set; }
    public decimal? RentId { get; set; }
    public decimal? IncomeId { get; set; }
    public decimal? PercId { get; set; }
    public decimal? BoxOut { get; set; }
    public decimal? BoxBalance { get; set; }
    public decimal? OpenRegNum { get; set; }
    public decimal? OpenBox { get; set; }
    public decimal? OpenPrice { get; set; }
    public decimal? OpenTotal { get; set; }
    public string? WrittenBy { get; set; }
    public DateTime? OpenDt { get; set; }
    public decimal? OpenAccount { get; set; }
    public decimal? PurchaseId { get; set; }
    public decimal? SaleId { get; set; }
    public decimal? HalkId { get; set; }
    public Guid Rowguid { get; set; }
}
