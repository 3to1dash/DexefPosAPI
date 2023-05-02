namespace DataAccess.Domain.Models;

public class UserOpenDayEntry
{
    public int Id { get; set; }
    public int? DayId { get; set; }
    public string? Username { get; set; }
    public int? PaymentId { get; set; }
    public int? AccountId { get; set; }
    public decimal? OpenTaskId { get; set; }
    public decimal? OpeningBalance { get; set; }
    public int? OpenRegNum { get; set; }
    public decimal? Debit { get; set; }
    public decimal? Credit { get; set; }
    public decimal? Balance { get; set; }
    public decimal? CloseBalance { get; set; }
    public decimal? Shortage { get; set; }
    public decimal? Extra { get; set; }
    public decimal? CloseTaskId { get; set; }
    public int? ShortageId { get; set; }
    public int? ExtraId { get; set; }
    public int? CloseAccountId { get; set; }
    public string? Currency { get; set; }
    public decimal? Rate { get; set; }
    public int? RegNum { get; set; }
    public Guid Rowguid { get; set; }
}