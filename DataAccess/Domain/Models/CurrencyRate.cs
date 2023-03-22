namespace DataAccess.Domain.Models;

public class CurrencyRate
{
    public decimal Id { get; set; }
    public decimal? CurrencyId { get; set; }
    public decimal? BuyRate { get; set; }
    public decimal? SaleRate { get; set; }
    public decimal? ReferCurrencyId { get; set; }
    public Guid Rowguid { get; set; }
}
