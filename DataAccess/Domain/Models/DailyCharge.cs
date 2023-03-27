namespace DataAccess.Domain.Models;

public class DailyCharge
{
    public long Id { get; set; }
    public int? DiscountId { get; set; }
    public decimal? DiscountPerc { get; set; }
    public decimal? Amount { get; set; }
    public string? Currency { get; set; }
    public decimal? Rate { get; set; }
    public decimal? TotalAmount { get; set; }
    public decimal? TaskId { get; set; }
    public long? RegNum { get; set; }
    public DateTime? Dt { get; set; }
    public string? Num { get; set; }
    public string? Dealing { get; set; }
    public int? AccountId { get; set; }
    public bool? IsCredit { get; set; }
    public bool? IsCust { get; set; }
    public bool? Started { get; set; }
    public DateTime? StartDate { get; set; }
    public bool? Ended { get; set; }
    public DateTime? EndDate { get; set; }
    public decimal? ReturnMoney { get; set; }
    public string? Driver { get; set; }
    public string? CarNumber { get; set; }
    public string? FullAddress { get; set; }
    public decimal? SumBill { get; set; }
    public int? ItemCount { get; set; }
    public Guid Rowguid { get; set; }
}