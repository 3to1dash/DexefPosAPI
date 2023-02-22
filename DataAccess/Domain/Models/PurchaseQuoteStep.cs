namespace DataAccess.Domain.Models;

public partial class PurchaseQuoteStep
{
    public decimal Id { get; set; }
    public decimal? TaskId { get; set; }
    public string? Role { get; set; }
    public bool? Waiting { get; set; }
    public bool? UnderCheck { get; set; }
    public string? UnderCheckUser { get; set; }
    public DateTime? UnderCheckDt { get; set; }
    public bool? Confirmed { get; set; }
    public string? ConfirmedUser { get; set; }
    public DateTime? ConfirmedDt { get; set; }
    public Guid Rowguid { get; set; }
}
